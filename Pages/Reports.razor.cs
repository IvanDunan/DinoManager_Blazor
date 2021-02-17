using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinoManager_Blazor.Models;
using DataLibrary;
using Microsoft.Extensions.Configuration;

namespace DinoManager_Blazor.Pages
{
    public partial class Reports
    {
        List<PersonModel> people;

        private async Task InsertData()
        {
            string sql = "insert into people (FirstName, LastName) values (@FirstName, @LastName);";

            await _data.SaveData(sql, new { FirstName = "Billy", LastName = "Bob" }, _config.GetConnectionString("default"));

            await OnInitializedAsync();
        }

        private async Task UpdateData()
        {
            string sql = "update people set FirstName = @FirstName where LastName = @LastName";

            await _data.SaveData(sql, new { FirstName = "Timothy", LastName = "Corey" }, _config.GetConnectionString("default"));

            await OnInitializedAsync();
        }

        private async Task DeleteData()
        {
            string sql = "delete from people where LastName = @LastName";

            await _data.SaveData(sql, new { LastName = "Bob" }, _config.GetConnectionString("default"));

            await OnInitializedAsync();
        }

        protected override async Task OnInitializedAsync()
        {
            string sql = "select * from people";

            people = await _data.LoadData<PersonModel, dynamic>(sql, new { }, _config.GetConnectionString("default"));
        }
    }
}
