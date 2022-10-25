using StudentAdminPortal.API.DataModels;
using Microsoft.EntityFrameworkCore;


namespace StudentAdminPortal.API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _studentRepo;
        public StudentRepository(StudentAdminContext studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await  _studentRepo.Students.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

    }
}
