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
    /// <summary>
    /// Product Controller
    /// </summary>
    [ApiController]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductRepository _pRepo;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository pRepo, IMapper mapper)
        {
            _pRepo = pRepo;
            _mapper = mapper;
        }

        /// <summary>
        /// Get the product details
        /// </summary>
        /// <param name="productId">productId to get the product details</param>
        /// <returns></returns>
        // GET api/values/5W
        [HttpGet("{productId:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult GetProduct(int productId)
        {
            var obj = _pRepo.GetProduct(productId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<ProductDto>(obj);
            return Ok(objDto);
        }

        /// <summary>
        /// Get all the Product list
        /// </summary>
        /// <returns></returns>
        // GET: api/values
        [HttpGet]
        [Route("GetProducts")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductDto))]
        public IActionResult GetProducts()
        {
            var objList = _pRepo.GetAllProducts();
            var objDto = new List<ProductDto>();
            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<ProductDto>(obj));
            }
            return Ok(objDto.ToList());
        }


        /// <summary>
        /// Get the productAtribute details
        /// </summary>
        /// <param name="productId">productId to get the product attribute details</param>
        /// <returns></returns>
        // GET api/values/5W
        [HttpGet]
        [Route("GetProductAttributes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductAttributesDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public IActionResult GetProductAttributes(int productId)
        {
            var obj = _pRepo.GetProductAttributes(productId);
            if (obj == null)
            {
                return NotFound();
            }
            var objDto = _mapper.Map<ProductAttributesDto>(obj);
            return Ok(objDto);
        }
    }
}
