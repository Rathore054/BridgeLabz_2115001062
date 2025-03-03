using System;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using NLog;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public RegisterHelloBL(IRegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }

        public string registration(string name)
        {
            try
            {
                logger.Info($"Registration method called with name: {name}");
                return "Data from business layer " + _registerHelloRL.GetHello(name);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in registration method");
                return "Error processing registration";
            }
        }

        public bool loginuser(LoginDTO loginDTO)
        {
            try
            {
                logger.Info("LoginUser method called.");
                string frontendUsername = loginDTO.username;
                string frontendPassword = loginDTO.password;

                LoginDTO result = _registerHelloRL.getUsernamePassword(loginDTO);
                bool res = checkUsernamePassword(frontendUsername, frontendPassword, result);

                if (res)
                    logger.Info($"User {frontendUsername} logged in successfully.");
                else
                    logger.Warn($"Login failed for user {frontendUsername}.");

                return res;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in loginuser method");
                return false;
            }
        }

        private bool checkUsernamePassword(string frontendUsername, string frontendPassword, LoginDTO result)
        {
            try
            {
                return frontendUsername == result.username && frontendPassword == result.password;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in checkUsernamePassword method");
                return false;
            }
        }
    }
}
