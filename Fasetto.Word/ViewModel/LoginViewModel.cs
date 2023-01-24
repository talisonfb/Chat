using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;

namespace Fasetto.Word
{

    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Private Member


        #endregion

        #region Public Properties

        /// <summary>
        /// The email fo the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        /// <summary>
        /// The users password 
        /// </summary>
        public SecureString Password { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
 
        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {

            // Create commands
            LoginCommand = new RelayParameterizedCommand(async(parameter) => await Login(parameter));
            
        }

        #endregion

        #region Teste

        /// <summary>
        /// Attemps to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> past in from the user view for the user password</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(5000);
                var email = this.Email;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });


        }

        #endregion

    }
}
