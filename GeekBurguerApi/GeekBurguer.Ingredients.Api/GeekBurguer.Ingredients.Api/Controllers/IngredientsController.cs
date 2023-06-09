﻿using AutoMapper;
using GeekBurger.Ingredients.Api.Data.Intefaces;
using GeekBurguer.Ingredients.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace GeekBurguer.Ingredients.Api.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public IngredientsController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet("ingredients/products")]
        public async Task<IActionResult> Get([FromQuery] string restrictions)
        {
            try
            {
                IEnumerable<string> listRestrictions = !string.IsNullOrEmpty(restrictions) ? restrictions.Split(",") : null;

                var products = await _productRepository.Get(listRestrictions);

                var response = _mapper.Map<IEnumerable<ProductResponse>>(products);

                return Ok(response);
            }
            catch (Exception ex)
            {
                //var telemetry = new TelemetryClient();
                //telemetry.TrackException(ex);

                return StatusCode(500, ex);
            }
        }
    }
}
