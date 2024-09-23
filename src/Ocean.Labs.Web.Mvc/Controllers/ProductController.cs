using Microsoft.AspNetCore.Mvc;
using Ocean.Labs.Model;
using System.Threading.Tasks;
using Ocean.Labs.Message;
using System;
using Ocean.Labs.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ocean.Labs.Controllers;

namespace Ocean.Labs.Web.Controllers
{
    public class ProductController : LabsControllerBase
    {
        private readonly ProductStock _productStock;
        private readonly LabsDbContext _context;
        private readonly MessagingService _messagingService;

        public ProductController(ProductStock productStock, LabsDbContext context, MessagingService messagingService)
        {
            _productStock = productStock;
            _context = context;
            _messagingService = messagingService;
        }

        // Display the product list
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        // Place an order
        [HttpPost]
        public async Task<IActionResult> PlaceOrder(int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return NotFound();

            // Calculate order amount (for demo purposes, assuming price is 10 per unit)
            var order = new Order
            {
                OrderNumber = Guid.NewGuid().ToString(),
                ProductId = productId,
                Quantity = quantity,
                Amount = quantity * 10,
                OrderDate = DateTime.Now
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Update stock using ProductStock class
            await _productStock.UpdateStockAsync(productId, quantity);

            // Send a message to RabbitMQ
            _messagingService.SendMessage($"Order placed for {quantity} units of Product ID {productId}.");

            return RedirectToAction(nameof(Index));
        }

        // View order list
        public async Task<IActionResult> Orders()
        {
            var orders = await _context.Orders.Include(o => o.ProductId).ToListAsync();
            return View(orders);
        }
    }

}
