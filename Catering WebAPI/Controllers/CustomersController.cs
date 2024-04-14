﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Catering_WebAPI.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Catering_WebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace Catering_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly DataContext _context;

        public CustomersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            var customers = await _context.Customers.ToListAsync();

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer is null)
                return NotFound("Customer not found.");

            return Ok(customer);
        }
        [HttpPost]
        public async Task<ActionResult<List<Customer>>> AddCustomer(Customer customer)
        {
             _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return Ok(await _context.Customers.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Customer>>> UpdateCustomer(Customer updatedCustomer)
        {
            var dbCustomer = await _context.Customers.FindAsync(updatedCustomer.CustomerId);
            if (dbCustomer is null)
                return NotFound("Customer not found.");

            dbCustomer.Name = updatedCustomer.Name;
            dbCustomer.Surname = updatedCustomer.Surname;
            dbCustomer.Email = updatedCustomer.Email;
            dbCustomer.Country = updatedCustomer.Country;

            await _context.SaveChangesAsync();

            return Ok(await _context.Customers.ToListAsync());
        }
        [HttpDelete]
        public async Task<ActionResult<List<Customer>>> DeleteCustomer(int id)
        {
            var dbCustomer = await _context.Customers.FindAsync(id);
            if (dbCustomer is null)
                return NotFound("Customer not found.");
            _context.Customers.Remove(dbCustomer);
            await _context.SaveChangesAsync();


            return Ok(await _context.Customers.ToListAsync());
        }

    }
}
