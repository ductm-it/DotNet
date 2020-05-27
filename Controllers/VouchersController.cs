using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uit_project_framework.Models;

namespace uit_project_framework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VouchersController : ControllerBase
    {
        private readonly ShopContext _context;

        public VouchersController(ShopContext context)
        {
            _context = context;
        }

        // GET: api/Vouchers
        [HttpGet]
        public IEnumerable<Voucher> GetVouchers()
        {
            return _context.Vouchers;
        }

        // GET: api/Vouchers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucher([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var voucher = await _context.Vouchers.FindAsync(id);

            if (voucher == null)
            {
                return NotFound();
            }

            return Ok(voucher);
        }

        [Route("/check/{voucherCode}")]
        //[HttpGet("{voucherCode}")]
        public async Task<IActionResult> CheckVoucher([FromRoute] string voucherCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var voucher = _context.Vouchers.Where(x => x.VoucherCode == voucherCode).ToList();

            if (voucher.Count > 0 && voucher[0].Status=="INVALID")
            {
                return Ok("[]");
            }

            return Ok(voucher);
        }

        [Route("/useCode/{voucherCode}")]
        public async Task<IActionResult> UseCode([FromRoute] string voucherCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var voucher = _context.Vouchers.Where(x => x.VoucherCode == voucherCode).ToList();
            if (voucher.Count > 0)
            {
                int usedVoucherId = voucher[0].VoucherId;

                var usedVoucher = _context.Vouchers.Find(usedVoucherId);
                if (usedVoucher.Status != null)
                {
                    usedVoucher.Status = "INVALID";
                }

                _context.SaveChanges();


            }



            return Ok(voucher);
        }

        // PUT: api/Vouchers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoucher([FromRoute] int id, [FromBody] Voucher voucher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != voucher.VoucherId)
            {
                return BadRequest();
            }

            _context.Entry(voucher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherExists(id))
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

        // POST: api/Vouchers
        [HttpPost]
        public async Task<IActionResult> PostVoucher([FromBody] Voucher voucher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Vouchers.Add(voucher);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoucher", new { id = voucher.VoucherId }, voucher);
        }

        // DELETE: api/Vouchers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucher([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var voucher = await _context.Vouchers.FindAsync(id);
            if (voucher == null)
            {
                return NotFound();
            }

            _context.Vouchers.Remove(voucher);
            await _context.SaveChangesAsync();

            return Ok(voucher);
        }

        private bool VoucherExists(int id)
        {
            return _context.Vouchers.Any(e => e.VoucherId == id);
        }
    }
}