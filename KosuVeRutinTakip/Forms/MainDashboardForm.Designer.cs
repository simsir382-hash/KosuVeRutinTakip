namespace KosuVeRutinTakip.Forms
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        // Antrenman Etiketleri ve Kontrolleri
        private System.Windows.Forms.Label lblActType;
        private System.Windows.Forms.Label lblWorkDate;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.Label lblDur;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbActivityType;
        private System.Windows.Forms.DateTimePicker dtpWorkoutDate;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnUpdateWorkout;
        private System.Windows.Forms.Button btnDeleteWorkout;
        private System.Windows.Forms.DataGridView dgvWorkouts;

        // Rutin Etiketleri ve Kontrolleri
        private System.Windows.Forms.Label lblRoutDate;
        private System.Windows.Forms.Label lblSleep;
        private System.Windows.Forms.DateTimePicker dtpRoutineDate;
        private System.Windows.Forms.TextBox txtSleepHours;
        private System.Windows.Forms.CheckBox chkColdShower;
        private System.Windows.Forms.CheckBox chkMeditation;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.Button btnAddRoutine;
        private System.Windows.Forms.Button btnUpdateRoutine;
        private System.Windows.Forms.Button btnDeleteRoutine;
        private System.Windows.Forms.DataGridView dgvRoutines;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblActType = new System.Windows.Forms.Label();
            this.lblWorkDate = new System.Windows.Forms.Label();
            this.lblDist = new System.Windows.Forms.Label();
            this.lblDur = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.btnDeleteWorkout = new System.Windows.Forms.Button();
            this.btnUpdateWorkout = new System.Windows.Forms.Button();
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.dtpWorkoutDate = new System.Windows.Forms.DateTimePicker();
            this.cmbActivityType = new System.Windows.Forms.ComboBox();

            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRoutDate = new System.Windows.Forms.Label();
            this.lblSleep = new System.Windows.Forms.Label();
            this.dgvRoutines = new System.Windows.Forms.DataGridView();
            this.btnDeleteRoutine = new System.Windows.Forms.Button();
            this.btnUpdateRoutine = new System.Windows.Forms.Button();
            this.btnAddRoutine = new System.Windows.Forms.Button();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkMeditation = new System.Windows.Forms.CheckBox();
            this.chkColdShower = new System.Windows.Forms.CheckBox();
            this.txtSleepHours = new System.Windows.Forms.TextBox();
            this.dtpRoutineDate = new System.Windows.Forms.DateTimePicker();

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutines)).BeginInit();
            this.SuspendLayout();

            // Üst Başlık ve İstatistik
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(15, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Hoş geldin";

            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStats.Location = new System.Drawing.Point(15, 42);
            this.lblStats.Name = "lblStats";
            this.lblStats.Text = "İstatistikler yükleniyor...";

            // TabControl
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(850, 485);

            // --- SEKME 1: ANTRENMAN TAKİBİ ---
            this.tabPage1.Controls.Add(this.lblActType);
            this.tabPage1.Controls.Add(this.lblWorkDate);
            this.tabPage1.Controls.Add(this.lblDist);
            this.tabPage1.Controls.Add(this.lblDur);
            this.tabPage1.Controls.Add(this.lblNotes);
            this.tabPage1.Controls.Add(this.dgvWorkouts);
            this.tabPage1.Controls.Add(this.btnDeleteWorkout);
            this.tabPage1.Controls.Add(this.btnUpdateWorkout);
            this.tabPage1.Controls.Add(this.btnAddWorkout);
            this.tabPage1.Controls.Add(this.txtNotes);
            this.tabPage1.Controls.Add(this.txtDuration);
            this.tabPage1.Controls.Add(this.txtDistance);
            this.tabPage1.Controls.Add(this.dtpWorkoutDate);
            this.tabPage1.Controls.Add(this.cmbActivityType);
            this.tabPage1.Text = "Antrenman Takibi";

            this.lblActType.AutoSize = true;
            this.lblActType.Location = new System.Drawing.Point(15, 12);
            this.lblActType.Text = "Aktivite Türü:";

            this.cmbActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityType.Location = new System.Drawing.Point(15, 32);
            this.cmbActivityType.Name = "cmbActivityType";
            this.cmbActivityType.Size = new System.Drawing.Size(160, 23);

            this.lblWorkDate.AutoSize = true;
            this.lblWorkDate.Location = new System.Drawing.Point(190, 12);
            this.lblWorkDate.Text = "Tarih:";

            this.dtpWorkoutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWorkoutDate.Location = new System.Drawing.Point(190, 32);
            this.dtpWorkoutDate.Name = "dtpWorkoutDate";
            this.dtpWorkoutDate.Size = new System.Drawing.Size(110, 23);

            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(315, 12);
            this.lblDist.Text = "Mesafe (km):";

            this.txtDistance.Location = new System.Drawing.Point(315, 32);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(80, 23);

            this.lblDur.AutoSize = true;
            this.lblDur.Location = new System.Drawing.Point(410, 12);
            this.lblDur.Text = "Süre (dk):";

            this.txtDuration.Location = new System.Drawing.Point(410, 32);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(80, 23);

            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(505, 12);
            this.lblNotes.Text = "Notlar:";

            this.txtNotes.Location = new System.Drawing.Point(505, 32);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(220, 23);

            this.btnAddWorkout.Location = new System.Drawing.Point(15, 68);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(90, 30);
            this.btnAddWorkout.Text = "Ekle";
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);

            this.btnUpdateWorkout.Location = new System.Drawing.Point(115, 68);
            this.btnUpdateWorkout.Name = "btnUpdateWorkout";
            this.btnUpdateWorkout.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateWorkout.Text = "Güncelle";
            this.btnUpdateWorkout.Click += new System.EventHandler(this.btnUpdateWorkout_Click);

            this.btnDeleteWorkout.Location = new System.Drawing.Point(215, 68);
            this.btnDeleteWorkout.Name = "btnDeleteWorkout";
            this.btnDeleteWorkout.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteWorkout.Text = "Sil";
            this.btnDeleteWorkout.Click += new System.EventHandler(this.btnDeleteWorkout_Click);

            this.dgvWorkouts.AllowUserToAddRows = false;
            this.dgvWorkouts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkouts.Location = new System.Drawing.Point(15, 112);
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.ReadOnly = true;
            this.dgvWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkouts.Size = new System.Drawing.Size(810, 330);
            this.dgvWorkouts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkouts_CellClick);

            // --- SEKME 2: UYKU VE GÜNLÜK RUTİN ---
            this.tabPage2.Controls.Add(this.lblRoutDate);
            this.tabPage2.Controls.Add(this.lblSleep);
            this.tabPage2.Controls.Add(this.dgvRoutines);
            this.tabPage2.Controls.Add(this.btnDeleteRoutine);
            this.tabPage2.Controls.Add(this.btnUpdateRoutine);
            this.tabPage2.Controls.Add(this.btnAddRoutine);
            this.tabPage2.Controls.Add(this.chkReading);
            this.tabPage2.Controls.Add(this.chkMeditation);
            this.tabPage2.Controls.Add(this.chkColdShower);
            this.tabPage2.Controls.Add(this.txtSleepHours);
            this.tabPage2.Controls.Add(this.dtpRoutineDate);
            this.tabPage2.Text = "Uyku ve Günlük Rutin";

            this.lblRoutDate.AutoSize = true;
            this.lblRoutDate.Location = new System.Drawing.Point(15, 12);
            this.lblRoutDate.Text = "Tarih:";

            this.dtpRoutineDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRoutineDate.Location = new System.Drawing.Point(15, 32);
            this.dtpRoutineDate.Name = "dtpRoutineDate";
            this.dtpRoutineDate.Size = new System.Drawing.Size(110, 23);

            this.lblSleep.AutoSize = true;
            this.lblSleep.Location = new System.Drawing.Point(140, 12);
            this.lblSleep.Text = "Uyku (saat):";

            this.txtSleepHours.Location = new System.Drawing.Point(140, 32);
            this.txtSleepHours.Name = "txtSleepHours";
            this.txtSleepHours.Size = new System.Drawing.Size(80, 23);

            this.chkColdShower.AutoSize = true;
            this.chkColdShower.Location = new System.Drawing.Point(240, 34);
            this.chkColdShower.Name = "chkColdShower";
            this.chkColdShower.Text = "Soğuk Duş";

            this.chkMeditation.AutoSize = true;
            this.chkMeditation.Location = new System.Drawing.Point(340, 34);
            this.chkMeditation.Name = "chkMeditation";
            this.chkMeditation.Text = "Meditasyon";

            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(440, 34);
            this.chkReading.Name = "chkReading";
            this.chkReading.Text = "Kitap Okuma";

            this.btnAddRoutine.Location = new System.Drawing.Point(15, 68);
            this.btnAddRoutine.Name = "btnAddRoutine";
            this.btnAddRoutine.Size = new System.Drawing.Size(90, 30);
            this.btnAddRoutine.Text = "Ekle";
            this.btnAddRoutine.Click += new System.EventHandler(this.btnAddRoutine_Click);

            this.btnUpdateRoutine.Location = new System.Drawing.Point(115, 68);
            this.btnUpdateRoutine.Name = "btnUpdateRoutine";
            this.btnUpdateRoutine.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateRoutine.Text = "Güncelle";
            this.btnUpdateRoutine.Click += new System.EventHandler(this.btnUpdateRoutine_Click);

            this.btnDeleteRoutine.Location = new System.Drawing.Point(215, 68);
            this.btnDeleteRoutine.Name = "btnDeleteRoutine";
            this.btnDeleteRoutine.Size = new System.Drawing.Size(90, 30);
            this.btnDeleteRoutine.Text = "Sil";
            this.btnDeleteRoutine.Click += new System.EventHandler(this.btnDeleteRoutine_Click);

            this.dgvRoutines.AllowUserToAddRows = false;
            this.dgvRoutines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoutines.Location = new System.Drawing.Point(15, 112);
            this.dgvRoutines.Name = "dgvRoutines";
            this.dgvRoutines.ReadOnly = true;
            this.dgvRoutines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoutines.Size = new System.Drawing.Size(810, 330);
            this.dgvRoutines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoutines_CellClick);

            // Form Ayarları
            this.ClientSize = new System.Drawing.Size(884, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koşu ve Rutin Takip Paneli";
            this.Load += new System.EventHandler(this.MainDashboardForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoutines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}