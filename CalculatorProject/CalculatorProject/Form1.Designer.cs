
namespace CalculatorProject
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonCover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EqualButton = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonZero = new System.Windows.Forms.Button();
            this.OneSymbolButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ButtonRound = new System.Windows.Forms.Button();
            this.ButtonPower = new System.Windows.Forms.Button();
            this.ButtonSquareRoot = new System.Windows.Forms.Button();
            this.ButtonProcent = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonPlusMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPi = new System.Windows.Forms.Button();
            this.ButtonFactorial = new System.Windows.Forms.Button();
            this.ButtonLg = new System.Windows.Forms.Button();
            this.ButtonLog = new System.Windows.Forms.Button();
            this.ButtonSin = new System.Windows.Forms.Button();
            this.ButtonSinh = new System.Windows.Forms.Button();
            this.ButtonCosh = new System.Windows.Forms.Button();
            this.ButtonCos = new System.Windows.Forms.Button();
            this.ButtonTanh = new System.Windows.Forms.Button();
            this.ButtonTan = new System.Windows.Forms.Button();
            this.ButtonAbs = new System.Windows.Forms.Button();
            this.ButtonMod = new System.Windows.Forms.Button();
            this.ButtonExp = new System.Windows.Forms.Button();
            this.ButtonE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Bombardier", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClose.Location = new System.Drawing.Point(477, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(45, 40);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonCover
            // 
            this.ButtonCover.FlatAppearance.BorderSize = 0;
            this.ButtonCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCover.Font = new System.Drawing.Font("Bombardier", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCover.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCover.Location = new System.Drawing.Point(435, 1);
            this.ButtonCover.Name = "ButtonCover";
            this.ButtonCover.Size = new System.Drawing.Size(42, 40);
            this.ButtonCover.TabIndex = 1;
            this.ButtonCover.Text = "-";
            this.ButtonCover.UseVisualStyleBackColor = true;
            this.ButtonCover.Click += new System.EventHandler(this.ButtonCover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mathematical Calculator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalculatorForm_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CalculatorForm_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "by CyberKaiser\'s software";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalculatorForm_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CalculatorForm_MouseMove);
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Enabled = false;
            this.TextBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(11, 62);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(495, 28);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(58, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(11, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(105, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(11, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 42);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(58, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 42);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(105, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 42);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(11, 189);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 42);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(58, 189);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 42);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Window;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(105, 189);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 42);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.SystemColors.Window;
            this.EqualButton.FlatAppearance.BorderSize = 0;
            this.EqualButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EqualButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualButton.Location = new System.Drawing.Point(105, 233);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(45, 42);
            this.EqualButton.TabIndex = 17;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonPoint.FlatAppearance.BorderSize = 0;
            this.ButtonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPoint.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPoint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPoint.Location = new System.Drawing.Point(11, 233);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(45, 42);
            this.ButtonPoint.TabIndex = 16;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = false;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // ButtonZero
            // 
            this.ButtonZero.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonZero.FlatAppearance.BorderSize = 0;
            this.ButtonZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonZero.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonZero.Location = new System.Drawing.Point(58, 233);
            this.ButtonZero.Name = "ButtonZero";
            this.ButtonZero.Size = new System.Drawing.Size(45, 42);
            this.ButtonZero.TabIndex = 15;
            this.ButtonZero.Text = "0";
            this.ButtonZero.UseVisualStyleBackColor = false;
            this.ButtonZero.Click += new System.EventHandler(this.ParametrsNumbers_Click);
            // 
            // OneSymbolButton
            // 
            this.OneSymbolButton.BackColor = System.Drawing.Color.DarkOrange;
            this.OneSymbolButton.FlatAppearance.BorderSize = 0;
            this.OneSymbolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OneSymbolButton.Font = new System.Drawing.Font("Bombardier", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneSymbolButton.Location = new System.Drawing.Point(170, 101);
            this.OneSymbolButton.Name = "OneSymbolButton";
            this.OneSymbolButton.Size = new System.Drawing.Size(45, 42);
            this.OneSymbolButton.TabIndex = 18;
            this.OneSymbolButton.Text = "<-";
            this.OneSymbolButton.UseVisualStyleBackColor = false;
            this.OneSymbolButton.Click += new System.EventHandler(this.OneSymbolButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(217, 101);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(45, 42);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ButtonRound
            // 
            this.ButtonRound.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonRound.FlatAppearance.BorderSize = 0;
            this.ButtonRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRound.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRound.Location = new System.Drawing.Point(264, 233);
            this.ButtonRound.Name = "ButtonRound";
            this.ButtonRound.Size = new System.Drawing.Size(45, 42);
            this.ButtonRound.TabIndex = 27;
            this.ButtonRound.Text = "≈";
            this.ButtonRound.UseVisualStyleBackColor = false;
            this.ButtonRound.Click += new System.EventHandler(this.ButtonRound_Click);
            // 
            // ButtonPower
            // 
            this.ButtonPower.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonPower.FlatAppearance.BorderSize = 0;
            this.ButtonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPower.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPower.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPower.Location = new System.Drawing.Point(170, 233);
            this.ButtonPower.Name = "ButtonPower";
            this.ButtonPower.Size = new System.Drawing.Size(45, 42);
            this.ButtonPower.TabIndex = 26;
            this.ButtonPower.Text = "aⁿ";
            this.ButtonPower.UseVisualStyleBackColor = false;
            this.ButtonPower.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonSquareRoot
            // 
            this.ButtonSquareRoot.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSquareRoot.FlatAppearance.BorderSize = 0;
            this.ButtonSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSquareRoot.Font = new System.Drawing.Font("Source Sans Pro Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSquareRoot.Location = new System.Drawing.Point(217, 233);
            this.ButtonSquareRoot.Name = "ButtonSquareRoot";
            this.ButtonSquareRoot.Size = new System.Drawing.Size(45, 42);
            this.ButtonSquareRoot.TabIndex = 25;
            this.ButtonSquareRoot.Text = "√x";
            this.ButtonSquareRoot.UseVisualStyleBackColor = false;
            this.ButtonSquareRoot.Click += new System.EventHandler(this.ButtonSquareRoot_Click);
            // 
            // ButtonProcent
            // 
            this.ButtonProcent.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonProcent.FlatAppearance.BorderSize = 0;
            this.ButtonProcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProcent.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonProcent.Location = new System.Drawing.Point(264, 189);
            this.ButtonProcent.Name = "ButtonProcent";
            this.ButtonProcent.Size = new System.Drawing.Size(45, 42);
            this.ButtonProcent.TabIndex = 24;
            this.ButtonProcent.Text = "%";
            this.ButtonProcent.UseVisualStyleBackColor = false;
            this.ButtonProcent.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonMultiply.FlatAppearance.BorderSize = 0;
            this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMultiply.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMultiply.Location = new System.Drawing.Point(170, 189);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(45, 42);
            this.ButtonMultiply.TabIndex = 23;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = false;
            this.ButtonMultiply.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonDivide.FlatAppearance.BorderSize = 0;
            this.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDivide.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDivide.Location = new System.Drawing.Point(217, 189);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(45, 42);
            this.ButtonDivide.TabIndex = 22;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = false;
            this.ButtonDivide.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonPlusMinus
            // 
            this.ButtonPlusMinus.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonPlusMinus.FlatAppearance.BorderSize = 0;
            this.ButtonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlusMinus.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlusMinus.Location = new System.Drawing.Point(264, 145);
            this.ButtonPlusMinus.Name = "ButtonPlusMinus";
            this.ButtonPlusMinus.Size = new System.Drawing.Size(45, 42);
            this.ButtonPlusMinus.TabIndex = 21;
            this.ButtonPlusMinus.Text = "±";
            this.ButtonPlusMinus.UseVisualStyleBackColor = false;
            this.ButtonPlusMinus.Click += new System.EventHandler(this.ButtonPlusMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonPlus.FlatAppearance.BorderSize = 0;
            this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPlus.Location = new System.Drawing.Point(170, 145);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(45, 42);
            this.ButtonPlus.TabIndex = 20;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = false;
            this.ButtonPlus.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonMinus.FlatAppearance.BorderSize = 0;
            this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinus.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMinus.Location = new System.Drawing.Point(217, 145);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(45, 42);
            this.ButtonMinus.TabIndex = 28;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = false;
            this.ButtonMinus.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonPi
            // 
            this.ButtonPi.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonPi.FlatAppearance.BorderSize = 0;
            this.ButtonPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPi.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPi.Location = new System.Drawing.Point(264, 101);
            this.ButtonPi.Name = "ButtonPi";
            this.ButtonPi.Size = new System.Drawing.Size(45, 42);
            this.ButtonPi.TabIndex = 29;
            this.ButtonPi.Text = "π";
            this.ButtonPi.UseVisualStyleBackColor = false;
            this.ButtonPi.Click += new System.EventHandler(this.ButtonPi_Click);
            // 
            // ButtonFactorial
            // 
            this.ButtonFactorial.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonFactorial.FlatAppearance.BorderSize = 0;
            this.ButtonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFactorial.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFactorial.Location = new System.Drawing.Point(311, 233);
            this.ButtonFactorial.Name = "ButtonFactorial";
            this.ButtonFactorial.Size = new System.Drawing.Size(45, 42);
            this.ButtonFactorial.TabIndex = 32;
            this.ButtonFactorial.Text = "n!";
            this.ButtonFactorial.UseVisualStyleBackColor = false;
            this.ButtonFactorial.Click += new System.EventHandler(this.ButtonFactorial_Click);
            // 
            // ButtonLg
            // 
            this.ButtonLg.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonLg.FlatAppearance.BorderSize = 0;
            this.ButtonLg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLg.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLg.Location = new System.Drawing.Point(311, 189);
            this.ButtonLg.Name = "ButtonLg";
            this.ButtonLg.Size = new System.Drawing.Size(45, 42);
            this.ButtonLg.TabIndex = 31;
            this.ButtonLg.Text = "ln";
            this.ButtonLg.UseVisualStyleBackColor = false;
            this.ButtonLg.Click += new System.EventHandler(this.ButtonLn_Click);
            // 
            // ButtonLog
            // 
            this.ButtonLog.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonLog.FlatAppearance.BorderSize = 0;
            this.ButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLog.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLog.Location = new System.Drawing.Point(311, 145);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(45, 42);
            this.ButtonLog.TabIndex = 30;
            this.ButtonLog.Text = "log";
            this.ButtonLog.UseVisualStyleBackColor = false;
            this.ButtonLog.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonSin
            // 
            this.ButtonSin.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSin.FlatAppearance.BorderSize = 0;
            this.ButtonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSin.Location = new System.Drawing.Point(369, 112);
            this.ButtonSin.Name = "ButtonSin";
            this.ButtonSin.Size = new System.Drawing.Size(67, 32);
            this.ButtonSin.TabIndex = 34;
            this.ButtonSin.Text = "Sin(x)";
            this.ButtonSin.UseVisualStyleBackColor = false;
            this.ButtonSin.Click += new System.EventHandler(this.ButtonSin_Click);
            // 
            // ButtonSinh
            // 
            this.ButtonSinh.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonSinh.FlatAppearance.BorderSize = 0;
            this.ButtonSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSinh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSinh.Location = new System.Drawing.Point(439, 112);
            this.ButtonSinh.Name = "ButtonSinh";
            this.ButtonSinh.Size = new System.Drawing.Size(67, 32);
            this.ButtonSinh.TabIndex = 35;
            this.ButtonSinh.Text = "Sinh(x)";
            this.ButtonSinh.UseVisualStyleBackColor = false;
            this.ButtonSinh.Click += new System.EventHandler(this.ButtonSinh_Click);
            // 
            // ButtonCosh
            // 
            this.ButtonCosh.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonCosh.FlatAppearance.BorderSize = 0;
            this.ButtonCosh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCosh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCosh.Location = new System.Drawing.Point(439, 146);
            this.ButtonCosh.Name = "ButtonCosh";
            this.ButtonCosh.Size = new System.Drawing.Size(67, 32);
            this.ButtonCosh.TabIndex = 37;
            this.ButtonCosh.Text = "Cosh(x)";
            this.ButtonCosh.UseVisualStyleBackColor = false;
            this.ButtonCosh.Click += new System.EventHandler(this.ButtonCosh_Click);
            // 
            // ButtonCos
            // 
            this.ButtonCos.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonCos.FlatAppearance.BorderSize = 0;
            this.ButtonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCos.Location = new System.Drawing.Point(369, 146);
            this.ButtonCos.Name = "ButtonCos";
            this.ButtonCos.Size = new System.Drawing.Size(67, 32);
            this.ButtonCos.TabIndex = 36;
            this.ButtonCos.Text = "Cos(x)";
            this.ButtonCos.UseVisualStyleBackColor = false;
            this.ButtonCos.Click += new System.EventHandler(this.ButtonCos_Click);
            // 
            // ButtonTanh
            // 
            this.ButtonTanh.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonTanh.FlatAppearance.BorderSize = 0;
            this.ButtonTanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTanh.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTanh.Location = new System.Drawing.Point(439, 180);
            this.ButtonTanh.Name = "ButtonTanh";
            this.ButtonTanh.Size = new System.Drawing.Size(67, 32);
            this.ButtonTanh.TabIndex = 39;
            this.ButtonTanh.Text = "Tanh(x)";
            this.ButtonTanh.UseVisualStyleBackColor = false;
            this.ButtonTanh.Click += new System.EventHandler(this.ButtonTanh_Click);
            // 
            // ButtonTan
            // 
            this.ButtonTan.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonTan.FlatAppearance.BorderSize = 0;
            this.ButtonTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTan.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTan.Location = new System.Drawing.Point(369, 180);
            this.ButtonTan.Name = "ButtonTan";
            this.ButtonTan.Size = new System.Drawing.Size(67, 32);
            this.ButtonTan.TabIndex = 38;
            this.ButtonTan.Text = "Tan(x)";
            this.ButtonTan.UseVisualStyleBackColor = false;
            this.ButtonTan.Click += new System.EventHandler(this.ButtonTan_Click);
            // 
            // ButtonAbs
            // 
            this.ButtonAbs.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonAbs.FlatAppearance.BorderSize = 0;
            this.ButtonAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAbs.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAbs.Location = new System.Drawing.Point(369, 214);
            this.ButtonAbs.Name = "ButtonAbs";
            this.ButtonAbs.Size = new System.Drawing.Size(47, 38);
            this.ButtonAbs.TabIndex = 40;
            this.ButtonAbs.Text = "Abs";
            this.ButtonAbs.UseVisualStyleBackColor = false;
            this.ButtonAbs.Click += new System.EventHandler(this.ButtonAbs_Click);
            // 
            // ButtonMod
            // 
            this.ButtonMod.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonMod.FlatAppearance.BorderSize = 0;
            this.ButtonMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMod.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonMod.Location = new System.Drawing.Point(418, 214);
            this.ButtonMod.Name = "ButtonMod";
            this.ButtonMod.Size = new System.Drawing.Size(44, 38);
            this.ButtonMod.TabIndex = 41;
            this.ButtonMod.Text = "Mod";
            this.ButtonMod.UseVisualStyleBackColor = false;
            this.ButtonMod.Click += new System.EventHandler(this.ValueOperation);
            // 
            // ButtonExp
            // 
            this.ButtonExp.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonExp.FlatAppearance.BorderSize = 0;
            this.ButtonExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExp.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonExp.Location = new System.Drawing.Point(464, 214);
            this.ButtonExp.Name = "ButtonExp";
            this.ButtonExp.Size = new System.Drawing.Size(42, 38);
            this.ButtonExp.TabIndex = 42;
            this.ButtonExp.Text = "Exp";
            this.ButtonExp.UseVisualStyleBackColor = false;
            this.ButtonExp.Click += new System.EventHandler(this.ButtonExp_Click);
            // 
            // ButtonE
            // 
            this.ButtonE.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonE.FlatAppearance.BorderSize = 0;
            this.ButtonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonE.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonE.Location = new System.Drawing.Point(311, 101);
            this.ButtonE.Name = "ButtonE";
            this.ButtonE.Size = new System.Drawing.Size(45, 42);
            this.ButtonE.TabIndex = 33;
            this.ButtonE.Text = "e";
            this.ButtonE.UseVisualStyleBackColor = false;
            this.ButtonE.Click += new System.EventHandler(this.ButtonE_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(521, 296);
            this.Controls.Add(this.ButtonExp);
            this.Controls.Add(this.ButtonMod);
            this.Controls.Add(this.ButtonAbs);
            this.Controls.Add(this.ButtonTanh);
            this.Controls.Add(this.ButtonTan);
            this.Controls.Add(this.ButtonCosh);
            this.Controls.Add(this.ButtonCos);
            this.Controls.Add(this.ButtonSinh);
            this.Controls.Add(this.ButtonSin);
            this.Controls.Add(this.ButtonE);
            this.Controls.Add(this.ButtonFactorial);
            this.Controls.Add(this.ButtonLg);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.ButtonPi);
            this.Controls.Add(this.ButtonMinus);
            this.Controls.Add(this.ButtonRound);
            this.Controls.Add(this.ButtonPower);
            this.Controls.Add(this.ButtonSquareRoot);
            this.Controls.Add(this.ButtonProcent);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonPlusMinus);
            this.Controls.Add(this.ButtonPlus);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OneSymbolButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.ButtonPoint);
            this.Controls.Add(this.ButtonZero);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCover);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalculatorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CalculatorForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonCover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button ButtonZero;
        private System.Windows.Forms.Button OneSymbolButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ButtonRound;
        private System.Windows.Forms.Button ButtonPower;
        private System.Windows.Forms.Button ButtonSquareRoot;
        private System.Windows.Forms.Button ButtonProcent;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonPlusMinus;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button ButtonPi;
        private System.Windows.Forms.Button ButtonFactorial;
        private System.Windows.Forms.Button ButtonLg;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.Button ButtonSin;
        private System.Windows.Forms.Button ButtonSinh;
        private System.Windows.Forms.Button ButtonCosh;
        private System.Windows.Forms.Button ButtonCos;
        private System.Windows.Forms.Button ButtonTanh;
        private System.Windows.Forms.Button ButtonTan;
        private System.Windows.Forms.Button ButtonAbs;
        private System.Windows.Forms.Button ButtonMod;
        private System.Windows.Forms.Button ButtonExp;
        private System.Windows.Forms.Button ButtonE;
    }
}

