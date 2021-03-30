using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.Data
{
    public class StaffData : IStaffData
    {
        private readonly ISqlDataAccess _db;

        public StaffData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<StaffModel>> GetStaff()
        {
            string sql = "SELECT * FROM dbo.Staff";

            return _db.LoadData<StaffModel, dynamic>(sql, new { });
        }

        public Task AddStaff(StaffModel model)
        {
            string sql = @"INSERT INTO dbo.Staff ([Id], [Image], [Name], [Category],[Post]) VALUES (@Id,@Image,@Name,@Category,@Post)";
            return _db.SaveData(sql,
                new
                {
                    Id = model.Id, Image = model.Image, Name = model.Name, Category = model.Category, Post = model.Post
                });
        }
        
        
    }
}