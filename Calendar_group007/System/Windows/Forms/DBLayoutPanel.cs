namespace System.Windows.Forms
{
    /// <summary>
    /// Double Buffered layout panel - removes flicker during resize operations.
    /// http://www.richard-banks.org/2007/09/how-to-create-flicker-free.html
    /// </summary>
    internal class DBLayoutPanel : TableLayoutPanel
    {
        public DBLayoutPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        public DBLayoutPanel(System.ComponentModel.IContainer container)
        {
            container.Add(this);
            SetStyle(ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// Double buffer
        /// </summary>
        [System.ComponentModel.Description("Double buffer")]
        [System.ComponentModel.DefaultValue(true)]
        public bool dBuffer
        {
            get { return this.DoubleBuffered; }
            set { this.DoubleBuffered = value; }
        }
    }
}