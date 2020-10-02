using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Data;
using ProductCatalogAPI.Models;

namespace ProductCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ProductCatalogAPIContext _context;

        public CategoriesController(ProductCatalogAPIContext context)
        {
            _context = context;
        }

        // GET: api/categories
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<ProductCategory>>> GetCategories()
        {
            return await _context.ProductCategory.ToListAsync();
        }

        // GET: api/categories/5
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProductCategory>> GetCategory(int id)
        {
            var productCategory = await _context.ProductCategory.FindAsync(id);

            if (productCategory == null)
            {
                return NotFound();
            }

            return productCategory;
        }

        // PUT: api/categories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut()]
        [Route("{categoryId}")]
        public async Task<IActionResult> UpdateCategory(int categoryId, ProductCategory productCategory)
        {
            if (categoryId != productCategory.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(productCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCategoryExists(categoryId))
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

        // POST: api/category
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("category")]
        public async Task<ActionResult<ProductCategory>> CreateCategory(ProductCategory productCategory)
        {
            _context.ProductCategory.Add(productCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductCategory", new { id = productCategory.CategoryId }, productCategory);
        }

        // DELETE: api/categories/5
        [HttpDelete()]
        [Route("{id}")]
        public async Task<ActionResult<ProductCategory>> DeleteCategory(int id)
        {
            var productCategory = await _context.ProductCategory.FindAsync(id);
            if (productCategory == null)
            {
                return NotFound();
            }

            _context.ProductCategory.Remove(productCategory);
            await _context.SaveChangesAsync();

            return productCategory;
        }

        private bool ProductCategoryExists(int id)
        {
            return _context.ProductCategory.Any(e => e.CategoryId == id);
        }
    }
}
