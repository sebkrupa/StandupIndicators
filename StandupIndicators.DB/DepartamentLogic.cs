using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandupIndicators.DB
{
    public class DepartamentLogic
    {
        public StandupDbContext DbContext { get; set; } = new StandupDbContext();

        public DepartamentLogic()
        {

        }
        public async Task<Enums.StatusEnum> AddDepartament(string name)
        {
            if (string.IsNullOrEmpty(name))
                return Enums.StatusEnum.SyntaxError;
            if (DbContext.Departaments.Any(x => x.Name == name))
                return Enums.StatusEnum.AlreadyExists;

            await DbContext.Departaments.AddAsync(new Model.Departament { Name = name });
            int result = await DbContext.SaveChangesAsync();
            if (result != 0)
                return Enums.StatusEnum.SaveFailure;
            return Enums.StatusEnum.OK;
        }

        public IEnumerable<Model.Departament> GetDepartaments()
        {
            return DbContext.Departaments;
        }
    }
}
