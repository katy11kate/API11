using RestfulAPI.Models;

namespace WebApplication3.ModelsDTO
{
    public class EmployeesResponseDTO
    {

        public string login { get; set; }

        public string password { get; set; }
        public string firstName { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }

        //public EmployeesResponseDTO(string login, string password, string firstName, string lastName, string patronymic)
        //{
        //    this.login = login;
        //    this.password = password;
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.patronymic = patronymic;
        //}
        public static EmployeesResponseDTO EmployeeResponseConverter(Employee employee)
        {
            EmployeesResponseDTO employeesResponseDTO = new EmployeesResponseDTO();
            employeesResponseDTO.password = employee.Password;
            employeesResponseDTO.firstName = employee.Firstname;
            employeesResponseDTO.name = employee.Name;
            employeesResponseDTO.patronymic = employee.Patronymic;
            employeesResponseDTO.login= employee.Login;

            return employeesResponseDTO;
        }
    }
}
