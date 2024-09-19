using System;
using System.ComponentModel.DataAnnotations;


namespace Test.Test.Sessions.Dto
{
    public class CreateOrderInputDTO
    {
        /// <summary>
        /// Gets or sets the Product ID.
        /// </summary>
        [Required] // Ensure this property is required
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the Quantity of the product.
        /// </summary>
        [Required] // Ensure this property is required
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the Order Number.
        /// This can be generated on the server or passed from the client.
        /// </summary>
        [Required]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets the Total Amount for the order.
        /// </summary>
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than 0")]
        public decimal TotalAmount { get; set; }
    }
}
