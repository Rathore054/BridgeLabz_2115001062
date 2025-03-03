using System;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using NLog;

namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public string databaseUsername = "root";
        public string databasePassword = "root";

        public RegisterHelloRL() { }

        public string GetHello(string name)
        {
            try
            {
                logger.Info($"GetHello called with name: {name}");
                return name + " hello from repository layer";
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in GetHello method");
                throw;
            }
        }

        public LoginDTO getUsernamePassword(LoginDTO loginDTO)
        {
            try
            {
                logger.Info("getUsernamePassword called");

                loginDTO.username = databaseUsername;
                loginDTO.password = databasePassword;

                return loginDTO;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error in getUsernamePassword method");
                throw;
            }
        }
    }
}
