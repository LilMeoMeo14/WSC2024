using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiProject.Data;

namespace WebApiProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderItemsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/OrderItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderItems>>> GetOrderItems()
        {
            return await _context.OrderItems
            .Include(oi => oi.Product) // load Product
            .ToListAsync();
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderItems>> GetOrderItems(int id)
        {
            var orderItems = await _context.OrderItems
                .Include(oi => oi.Product) // load thêm Product
                .FirstOrDefaultAsync(oi => oi.OrderItemId == id);

            if (orderItems == null)
            {
                return NotFound();
            }

            return orderItems;
        }

        // GET: api/OrderItems/order/5
        [HttpGet("order/{orderId}")]
        public async Task<ActionResult<IEnumerable<OrderItems>>> GetOrderItemsByOrder(int orderId)
        {
            var items = await _context.OrderItems
                .Include(oi => oi.Product)
                .Where(oi => oi.TransactionId == orderId) // TransactionId phải là FK tới Orders
                .ToListAsync();

            if (items == null || !items.Any())
            {
                return NotFound();
            }

            return items;
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItems(int id, OrderItems orderItems)
        {
            if (id != orderItems.OrderItemId)
            {
                return BadRequest();
            }

            _context.Entry(orderItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderItemsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItems>> PostOrderItems(OrderItems orderItems)
        {
            _context.OrderItems.Add(orderItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderItems", new { id = orderItems.OrderItemId }, orderItems);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItems(int id)
        {
            var orderItems = await _context.OrderItems.FindAsync(id);
            if (orderItems == null)
            {
                return NotFound();
            }

            _context.OrderItems.Remove(orderItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderItemsExists(int id)
        {
            return _context.OrderItems.Any(e => e.OrderItemId == id);
        }
    }
}
