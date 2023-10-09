﻿using AccountErp.Api.Helpers;
using AccountErp.Infrastructure.Managers;
using AccountErp.Managers;
using AccountErp.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using AccountErp.Utilities;
using AccountErp.Models.ShippingMethod;

namespace AccountErp.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ShippingMethodController : ControllerBase
    {
        private readonly IShippingMethodManager _manager;
        public ShippingMethodController(IShippingMethodManager manager)
        {
            _manager = manager;
        }


        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Add([FromBody] AddShippingMethodModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorList());
            }
            var response = new BaseResponse<object>();

            

            try
            {
                if (model != null)
                {
                    var shippingMethodId = await _manager.AddAsync(model);
                   
                    response.StatusCode = 200;
                    response.Message = Constants.added;
                    response.Data = shippingMethodId;
                    return Ok(response);

                }
                response.StatusCode = 404;
                response.Message = Constants.provideValues;
                return BadRequest(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("edit")]
        public async Task<IActionResult> Edit([FromBody] AddShippingMethodModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorList());
            }
            var response = new BaseResponse<object>();

            

            try
            {
                if (model.Id != 0)
                {
                    await _manager.EditAsync(model);
                    response.StatusCode = 200;
                    response.Message = Constants.updated;
                    return Ok(response);
                }
                response.StatusCode = 404;
                response.Message = Constants.provideValues;
                return BadRequest(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("get-detail/{id}")]
        public async Task<IActionResult> GetDetail(int id)
        {

            var response = new BaseResponse<object>();

            if (id != 0)
            {
                var data = await _manager.GetDetailAsync(id);
                if (data != null)
                {
                    response.StatusCode = 200;
                    response.Data = data;
                    return Ok(response);
                }
                else
                {
                    response.StatusCode = 404;
                    response.Message = "data not Present";
                    return Ok(response);
                }
            }
            response.StatusCode = 404;
            response.Message = Constants.provideValues;
            return BadRequest(response);
        }



        [HttpPost]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            var response = new BaseResponse<object>();

            if (id != 0)
            {
                await _manager.DeleteAsync(id);
                response.StatusCode = 200;
                response.Message = Constants.deleted;
                return Ok(response);
            }
            response.StatusCode = 404;
            response.Message = Constants.provideValues;
            return BadRequest(response);
        }


        [HttpPost]
        [Route("getall")]
        public async Task<IActionResult> GetPagedResult(int PageSize, int Page,string FilterKey)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorList());
            }
            var response = new BaseResponseGet<object>();
            var data = await _manager.GetAllAsync(PageSize, Page, FilterKey);
            if (data.Item1.Count != 0)
            {
                response.Data = data.Item1;
                response.TotalCount = data.count;
                response.StatusCode = 200;
                return Ok(response);
            }
            response.StatusCode = 404;
            response.Message = "data not present";
            return Ok(response);
        }
    }
}
