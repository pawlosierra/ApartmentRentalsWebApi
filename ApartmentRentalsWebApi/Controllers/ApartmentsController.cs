using ApartmentRentalsWebApi.Application.Commands.Apartments.AddApartment;
using ApartmentRentalsWebApi.Application.Commands.Apartments.DeleteApartment;
using ApartmentRentalsWebApi.Application.Commands.Apartments.UpdateApartment;
using ApartmentRentalsWebApi.Application.Queries.Apartments.GetApartmentByNumber;
using ApartmentRentalsWebApi.Application.Queries.Apartments.GetApartments;
using ApartmentRentalsWebApi.Domain.Models;
using ApartmentRentalsWebApi.DTOs.Apartments;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ApartmentRentalsWebApi.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public class ApartmentsController : ControllerBase
  {
    private readonly ILogger<ApartmentsController> _logger;
    private readonly IMediator                     _mediator;
    private readonly IMapper                       _mapper;
    public ApartmentsController(
      ILogger<ApartmentsController> logger,
      IMediator                     mediator,
      IMapper                       mapper)
    {
      _logger   = logger;
      _mediator = mediator;
      _mapper   = mapper;
    }
    [HttpGet]
    public async Task<IActionResult> GetApartments()
    {
      _logger.LogInformation("Get Apartments");
      var apartments = await _mediator.Send(new GetApartments());
      return Ok(_mapper.Map<IEnumerable<ApartmentResponse>>(apartments));
    }
    [HttpGet("search")]
    public async Task<IActionResult> GetApartmentByNumber(
      [FromQuery(Name = "apartmentNumber")]
      [Required(ErrorMessage = "The field apartmentNumber is riquired")]
      string apartmentNumber)
    {
      _logger.LogInformation("Get Apartment by apartment number");
      var apartment = await _mediator.Send(new GetApartmentByNumber(apartmentNumber));
      return Ok(_mapper.Map<ApartmentResponse>(apartment));
    }
    [HttpPost]
    public async Task<IActionResult> AddApartment(ApartmentRequest apartmentRequest)
    {
      _logger.LogInformation("Adding Apartment");
      var apartment = await _mediator.Send(new AddApartment(_mapper.Map<Apartment>(apartmentRequest)));
      return Ok(_mapper.Map<ApartmentResponse>(apartment));
    }
    [HttpPut("update")]
    public async Task<IActionResult> UpdateApartment(
      [FromQuery(Name = "apartmentId")]
      [Required(ErrorMessage = "The apartmentId is required")]
      Guid apartmentId, 
      ApartmentRequest apartmentRequest)
    {
      _logger.LogInformation("Updating Apartment");
      var apartment = await _mediator.Send(new UpdateApartment(apartmentId, 
                                                               _mapper.Map<Apartment>(apartmentRequest)));
      return Ok(_mapper.Map<ApartmentResponse>(apartment));
    }
    [HttpDelete]
    public async Task<IActionResult> DeleteApartment(
      [FromQuery(Name = "apartmentId")]
      [Required(ErrorMessage = "The field apartmentId is required")]
      Guid apartmentId)
    {
      _logger.LogInformation("Deleting Apartment");
      var apartment = await _mediator.Send(new DeleteApartment(apartmentId));
      return Ok(_mapper.Map<ApartmentResponse>(apartment));
    }
  }
}
