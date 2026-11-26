using System;
using System.Windows.Forms;
using KosuVeRutinTakip.Models;
using KosuVeRutinTakip.Services;

namespace KosuVeRutinTakip.Forms
{
    public partial class MainDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly WorkoutService _workoutService = new WorkoutService();
        private readonly DailyRoutineService _routineService = new DailyRoutineService();
        private readonly ActivityTypeService _activityService = new ActivityTypeService();

        private int _selectedWorkoutId = 0;
        private int _selectedRoutineId = 0;

        public MainDashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş geldin, {_currentUser.FullName}";
            LoadActivityTypes();
            RefreshAllData();
        }

        private void LoadActivityTypes()
        {
            cmbActivityType.DataSource = _activityService.GetAll();
            cmbActivityType.DisplayMember = "TypeName";
            cmbActivityType.ValueMember = "Id";
        }

        private void RefreshAllData()
        {
            // Antrenman listesi
            dgvWorkouts.DataSource = null;
            dgvWorkouts.DataSource = _workoutService.GetAllByUser(_currentUser.Id);
            if (dgvWorkouts.Columns["UserId"] != null) dgvWorkouts.Columns["UserId"].Visible = false;
            if (dgvWorkouts.Columns["ActivityTypeId"] != null) dgvWorkouts.Columns["ActivityTypeId"].Visible = false;

            // Rutin listesi
            dgvRoutines.DataSource = null;
            dgvRoutines.DataSource = _routineService.GetAllByUser(_currentUser.Id);
            if (dgvRoutines.Columns["UserId"] != null) dgvRoutines.Columns["UserId"].Visible = false;

            // İstatistik özeti (Service katmanından hesaplanır)
            decimal totalKm = _workoutService.GetTotalDistanceKm(_currentUser.Id);
            int totalMin = _workoutService.GetTotalDurationMinutes(_currentUser.Id);
            decimal avgSleep = _routineService.GetAverageSleepHours(_currentUser.Id);

            lblStats.Text = $"Toplam Mesafe: {totalKm} km  |  Toplam Süre: {totalMin} dk  |  Ortalama Uyku: {avgSleep} saat";
        }

        // --- ANTRENMAN CRUD İŞLEMLERİ ---
        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                var workout = new Workout
                {
                    UserId = _currentUser.Id,
                    ActivityTypeId = Convert.ToInt32(cmbActivityType.SelectedValue),
                    WorkoutDate = dtpWorkoutDate.Value,
                    DistanceKm = decimal.TryParse(txtDistance.Text, out decimal km) ? km : 0,
                    DurationMinutes = int.TryParse(txtDuration.Text, out int dk) ? dk : 0,
                    Notes = txtNotes.Text.Trim()
                };

                _workoutService.Add(workout);
                MessageBox.Show("Antrenman kaydedildi.");
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateWorkout_Click(object sender, EventArgs e)
        {
            if (_selectedWorkoutId == 0) { MessageBox.Show("Listeden güncellenecek satırı seçin."); return; }
            try
            {
                var workout = new Workout
                {
                    Id = _selectedWorkoutId,
                    UserId = _currentUser.Id,
                    ActivityTypeId = Convert.ToInt32(cmbActivityType.SelectedValue),
                    WorkoutDate = dtpWorkoutDate.Value,
                    DistanceKm = decimal.TryParse(txtDistance.Text, out decimal km) ? km : 0,
                    DurationMinutes = int.TryParse(txtDuration.Text, out int dk) ? dk : 0,
                    Notes = txtNotes.Text.Trim()
                };

                _workoutService.Update(workout);
                MessageBox.Show("Antrenman güncellendi.");
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteWorkout_Click(object sender, EventArgs e)
        {
            if (_selectedWorkoutId == 0) { MessageBox.Show("Listeden silinecek satırı seçin."); return; }
            _workoutService.Delete(_selectedWorkoutId);
            _selectedWorkoutId = 0;
            MessageBox.Show("Antrenman silindi.");
            RefreshAllData();
        }

        private void dgvWorkouts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvWorkouts.Rows[e.RowIndex];
            _selectedWorkoutId = Convert.ToInt32(row.Cells["Id"].Value);
            cmbActivityType.SelectedValue = Convert.ToInt32(row.Cells["ActivityTypeId"].Value);
            dtpWorkoutDate.Value = Convert.ToDateTime(row.Cells["WorkoutDate"].Value);
            txtDistance.Text = row.Cells["DistanceKm"].Value.ToString();
            txtDuration.Text = row.Cells["DurationMinutes"].Value.ToString();
            txtNotes.Text = row.Cells["Notes"].Value?.ToString();
        }

        // --- GÜNLÜK RUTİN CRUD İŞLEMLERİ ---
        private void btnAddRoutine_Click(object sender, EventArgs e)
        {
            try
            {
                var routine = new DailyRoutine
                {
                    UserId = _currentUser.Id,
                    RoutineDate = dtpRoutineDate.Value,
                    SleepHours = decimal.TryParse(txtSleepHours.Text, out decimal sh) ? sh : 0,
                    ColdShowerDone = chkColdShower.Checked,
                    MeditationDone = chkMeditation.Checked,
                    ReadingDone = chkReading.Checked
                };

                _routineService.Add(routine);
                MessageBox.Show("Günlük rutin kaydedildi.");
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateRoutine_Click(object sender, EventArgs e)
        {
            if (_selectedRoutineId == 0) { MessageBox.Show("Listeden güncellenecek satırı seçin."); return; }
            try
            {
                var routine = new DailyRoutine
                {
                    Id = _selectedRoutineId,
                    UserId = _currentUser.Id,
                    RoutineDate = dtpRoutineDate.Value,
                    SleepHours = decimal.TryParse(txtSleepHours.Text, out decimal sh) ? sh : 0,
                    ColdShowerDone = chkColdShower.Checked,
                    MeditationDone = chkMeditation.Checked,
                    ReadingDone = chkReading.Checked
                };

                _routineService.Update(routine);
                MessageBox.Show("Günlük rutin güncellendi.");
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteRoutine_Click(object sender, EventArgs e)
        {
            if (_selectedRoutineId == 0) { MessageBox.Show("Listeden silinecek satırı seçin."); return; }
            _routineService.Delete(_selectedRoutineId);
            _selectedRoutineId = 0;
            MessageBox.Show("Günlük rutin silindi.");
            RefreshAllData();
        }

        private void dgvRoutines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvRoutines.Rows[e.RowIndex];
            _selectedRoutineId = Convert.ToInt32(row.Cells["Id"].Value);
            dtpRoutineDate.Value = Convert.ToDateTime(row.Cells["RoutineDate"].Value);
            txtSleepHours.Text = row.Cells["SleepHours"].Value.ToString();
            chkColdShower.Checked = Convert.ToBoolean(row.Cells["ColdShowerDone"].Value);
            chkMeditation.Checked = Convert.ToBoolean(row.Cells["MeditationDone"].Value);
            chkReading.Checked = Convert.ToBoolean(row.Cells["ReadingDone"].Value);
        }
    }
}