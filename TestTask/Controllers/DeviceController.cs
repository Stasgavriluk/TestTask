using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestTask.Models;
using TestTask.Data;
using Azure;
using System.Net;
using TestTask.Models.DTO;

namespace TestTask.Controllers;

[ApiController]
[Route("/experiment/button-color")]
public class DeviceController : ControllerBase
{
    private readonly ApiContext _context;
    private readonly IMapper _mapper;
    protected APIResponse _response;

    public DeviceController(ApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        _response = new();
    }
    
    //[HttpGet("Id")]
    //public ActionResult<Device> Get(int id)
    //{
    //    if (id == 0)
    //    {
    //        return BadRequest();
    //    }
    //    var device = _context.Devices.FirstOrDefault(u => u.Id == id);
    //    if (device == null)
    //    {
    //        return NotFound();
    //    }
    //    return Ok(device);    
    //}

    
    [HttpGet]
    public async Task<ActionResult<APIResponse>> Get(int id)    
    {
        try
        {
            if (id == 0)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                return BadRequest(_response);
            }
            var device = _context.Devices.FirstOrDefault(u => u.Id == id);
            if (device == null)
            {
                _response.StatusCode = HttpStatusCode.NotFound;
                return NotFound(_response);
            }
            _response.Result = _mapper.Map<DeviceDTO>(device);
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages
                 = new List<string>() { ex.ToString() };
        }
        return _response;
    }
    
    [HttpGet("getAll")]
    public IQueryable<DeviceDTO> GetAll()
    {
        var books = from b in _context.Devices
                    select new DeviceDTO()
                    {
                        Id = b.Id,
                        Key = b.Key,
                        Price = b.Price,
                        Value = b.Value
                    };
        return books;        
    }
}

