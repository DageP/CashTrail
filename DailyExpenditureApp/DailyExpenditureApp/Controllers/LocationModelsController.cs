﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyExpenditureApp.Models;

namespace DailyExpenditureApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationModelsController : ControllerBase
    {
        private readonly ExpenseDetailContext _context;

        public LocationModelsController(ExpenseDetailContext context)
        {
            _context = context;
        }

        // GET: api/LocationModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LocationModel>>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }

        // GET: api/LocationModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LocationModel>> GetLocationModel(int id)
        {
            var locationModel = await _context.Locations.FindAsync(id);

            if (locationModel == null)
            {
                return NotFound();
            }

            return locationModel;
        }

        // PUT: api/LocationModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocationModel(int id, LocationModel locationModel)
        {
            if (id != locationModel.LocationID)
            {
                return BadRequest();
            }

            _context.Entry(locationModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationModelExists(id))
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

        // POST: api/LocationModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<LocationModel>> PostLocationModel(LocationModel locationModel)
        {
            _context.Locations.Add(locationModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLocationModel", new { id = locationModel.LocationID }, locationModel);
        }

        // DELETE: api/LocationModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocationModel(int id)
        {
            var locationModel = await _context.Locations.FindAsync(id);
            if (locationModel == null)
            {
                return NotFound();
            }

            _context.Locations.Remove(locationModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LocationModelExists(int id)
        {
            return _context.Locations.Any(e => e.LocationID == id);
        }
    }
}
