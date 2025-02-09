using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using SmartInventoryApp.Models;

namespace SmartInventoryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryTransactionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InventoryTransactionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InventoryTransactions
        [HttpGet]
        public ActionResult<IEnumerable<InventoryTransaction>> GetInventoryTransactions()
        {
            return _context.InventoryTransactions.ToList();
        }

        // GET: api/InventoryTransactions/5
        [HttpGet("{id}")]
        public ActionResult<InventoryTransaction> GetInventoryTransaction(int id)
        {
            var transaction = _context.InventoryTransactions.Find(id);

            if (transaction == null)
            {
                return NotFound();
            }

            return transaction;
        }

        // POST: api/InventoryTransactions
        [HttpPost]
        public ActionResult<InventoryTransaction> PostInventoryTransaction(InventoryTransaction transaction)
        {
            _context.InventoryTransactions.Add(transaction);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetInventoryTransaction), new { id = transaction.InventoryTransactionID }, transaction);
        }

        // PUT: api/InventoryTransactions/5
        [HttpPut("{id}")]
        public IActionResult PutInventoryTransaction(int id, InventoryTransaction transaction)
        {
            if (id != transaction.InventoryTransactionID)
            {
                return BadRequest();
            }

            _context.Entry(transaction).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/InventoryTransactions/5
        [HttpDelete("{id}")]
        public IActionResult DeleteInventoryTransaction(int id)
        {
            var transaction = _context.InventoryTransactions.Find(id);
            if (transaction == null)
            {
                return NotFound();
            }

            _context.InventoryTransactions.Remove(transaction);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
