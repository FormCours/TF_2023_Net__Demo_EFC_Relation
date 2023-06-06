using Demo_EFC_02.DAL;
using Microsoft.EntityFrameworkCore;


// Doc Many-to-Many
// → https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many

using (AppDbContext db = new AppDbContext())
{

    db.Products.Include(p => p.Category)
               .Include(p => p.Bundles);


}