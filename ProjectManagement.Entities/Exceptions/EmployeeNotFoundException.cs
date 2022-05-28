namespace ProjectManagement.Entities.Exceptions
{
    public sealed class EmployeeNotFoundException : NotFoundException
    {
        public EmployeeNotFoundException(Guid employeeId) : base($"The employee with {employeeId} doesn't exists.")
        {
        }
    }
}