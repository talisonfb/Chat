using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Fasetto.Word
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private Member

        /// <summary>
        /// The window this view controls 
        /// </summary>
        
        private Window mWindow;

        /// <summary>
        /// The margin around the window to allow for a drop shadow 
        /// </summary>
        private int mOuterMarginSize = 10;

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        private int mWindowRadius = 10;

        #endregion
        
        #region Public Properties

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>

        public int ResizeBorder { get; set; } = 6;

        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder); } }

        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMarginSize
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }
        
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>

        public WindowViewModel(Window window)
        {
            mWindow = window;
        }
        #endregion
    }
}
