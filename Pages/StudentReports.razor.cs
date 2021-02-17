using DinoManager_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DinoManager_Blazor.Pages
{
    public partial class StudentReports
    {
        List<StudentModel> student;

        private async Task InsertData()
        {
            string sql = "insert into users (name, surnames, sex, age,) values (@Name, @Surnames, @Sex, @Age);";

            await _data.SaveData(sql, new { Name = "Antonio", Surnames = "Martinez Calvo", Sex = "m", Age = 15 }, _config.GetConnectionString("default"));

            await OnInitializedAsync();
        }

        protected override async Task OnInitializedAsync()
        {
            string sql = "select * from users";

            student = await _data.LoadData<StudentModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }
    }
}
