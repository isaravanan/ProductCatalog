using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductData.IRepository;
using ProductData.Entity.Dto;
using AutoMapper;

namespace ProductCatalog.Controllers
{
    [ApiController]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("api/[controller]")]
    public class ProductAttributeController : Controller
    {
        private IProductRepository _pRepo;
        private readonly IMapper _mapper;

        public ProductAttributeController(IProductRepository pRepo, IMapper mapper)
        {
            _pRepo = pRepo;
            _mapper = mapper;
        }


        ///// <summary>
        ///// Get the productAtribute details
        ///// </summary>
        ///// <param name="productId">productId to get the product attribute details</param>
        ///// <returns></returns>
        //// GET api/values/5W
        //[Route("GetProductAttributes")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductAttributeDto))]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesDefaultResponseType]
        //public IActionResult GetProductAttributes(int productId)
        //{
        //    var obj = _pRepo.GetProductAttributes(productId);
        //    if (obj == null)
        //    {
        //        return NotFound();
        //    }
        //    var objDto = _mapper.Map<ProductAttributeDto>(obj);
        //    return Ok(objDto);
        //}
    }
}
