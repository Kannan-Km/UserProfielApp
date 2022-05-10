using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using UsersProfileApp.DataStore.Models;

namespace UsersProfileApp.DataStore.Repository
{
    public class FileStore : IDataStore
    {
        private string FilePath { get; set; }

        public IEnumerable<Users> GetUsers()
        {
            FilePath = GetFilePath();
            if(File.Exists(FilePath))
            {
                var json = ReadJsonString(FilePath);
                return JsonConvert.DeserializeObject<IEnumerable<Users>>(json);
            }
            return new List<Users>();
        }

        public void SaveUser(Users user)
        {
            FilePath = GetFilePath();
            var users = new List<Users>();
            if (File.Exists(FilePath))
            {
                var json = ReadJsonString(FilePath);
                users = JsonConvert.DeserializeObject<List<Users>>(json);
            }
            users.Add(user);
            string userData = JsonConvert.SerializeObject(users);
            using StreamWriter fs = new StreamWriter(FilePath);
            fs.Write(userData);
        }

        private string ReadJsonString(string FilePath)
        {
            using StreamReader r = new StreamReader(FilePath);
            return r.ReadToEnd();
        }

        private string GetFilePath()
        {
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory());
            return Path.Combine(pathToSave, "Data.json");
        }
    }
}
