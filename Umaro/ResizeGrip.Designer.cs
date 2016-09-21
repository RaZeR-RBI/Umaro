namespace Umaro
{
    partial class ResizeGrip
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ResizeGrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Umaro.Properties.Resources.resize_grip_se;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.DoubleBuffered = true;
            this.Name = "ResizeGrip";
            this.Size = new System.Drawing.Size(16, 16);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResizeGrip_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ResizeGrip_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ResizeGrip_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResizeGrip_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
