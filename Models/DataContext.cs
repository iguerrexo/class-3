using Microsoft.EntityFrameworkCore;

/*
this class will handle the connection between the code and the database

migrations:
process that compares the models and the db structure 
List the changes 

dotnet ef migrations add initial
dotnet ef database update
*/

namespace PropertyRental.Models {
    public class DataContext: DbContext{

        public DataContext(DbContextOptions<DataContext> options) :base(options){
            
        }
        //here declare all your classes that should become a table on the DB
        public DbSet<Property> Properties {get; set;}

    }
}