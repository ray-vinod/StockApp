using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Models.Helpers
{
    public class ManageStock
    {
        public static async Task UpdateStock(Guid id, AppDbContext _db)
        {
            int rcount = 0;//recieve item count
            int icount = 0;//issue item count

            //Count all from recieveproduct table
            var qtys = from r in _db.RecieveProducts
                            .Where(x => x.ProductId == id && x.IsDeleted == false)
                            .AsNoTracking()
                       group r by r.ProductId into g
                       select new
                       {
                           Qty = g.Sum(x => x.Qty),
                           Item = g.Key
                       };

            foreach (var qty in qtys)
            {
                rcount += qty.Qty;
            }

            //Count all from issueproduct table
            var issueQty = from r in _db.IssueProducts
                                .Where(x => x.ProductId == id && x.IsDeleted == false)
                                .AsNoTracking()
                           group r by r.ProductId into g
                           select new
                           {
                               Qty = g.Sum(x => x.Qty),
                               Item = g.Key
                           };

            foreach (var qty in issueQty)
            {
                icount += qty.Qty;
            }

            //updating stock table
            if (IsExist(id))
            {
                Stock stock = _db.StockProducts.Where(sp => sp.Id == id)
                                 .AsNoTracking()
                                 .First();
                stock.TotalRecieve = rcount;
                stock.TotalIssue = icount;
                stock.InStock = rcount - icount;
                _db.StockProducts.Update(stock);
                await _db.SaveChangesAsync();
                _db.Entry(stock).State = EntityState.Detached;

            }
            else
            {
                var product = await _db.Products.Where(p => p.Id == id)
                                       .AsNoTracking()
                                       .Select(x => new Stock
                                       {
                                           Id = x.Id,
                                           ProductName = ((x.ProductPrefix.Name == "NO") ? "" : x.ProductPrefix.Name) + " " + x.Name + " " +
                                                       x.ProductSufix.Name,
                                           TotalRecieve = rcount,
                                           TotalIssue = icount,
                                           InStock = rcount - icount
                                       })
                                       .FirstOrDefaultAsync();

                _db.StockProducts.Add(product);
                await _db.SaveChangesAsync();
                _db.Entry(product).State = EntityState.Detached;

            }

            bool IsExist(Guid id)
            {
                return _db.StockProducts.AsNoTracking().Any(p => p.Id == id);
            }
        }
    }
}
