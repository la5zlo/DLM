
using GoodsHandlerWebApi.Interface;
using GoodsHandlerWebApi.Modells;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace GoodsHandlerWebApi.Controllers
{
    [Route("inventory/[controller]")]
    [ApiController]
    public class GoodsController : Controller
    {
        private readonly IGoodsRepository _goodsRepository;


        public GoodsController(IGoodsRepository goodsRepository)
        {
            _goodsRepository = goodsRepository;

        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Goods>))]
        public IActionResult GetGoods()
        {
            var goods = _goodsRepository.GetGoods();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(goods);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateGood([FromBody] Goods goodCreate)
        {
            if (goodCreate == null)
                return BadRequest(ModelState);

            var good = _goodsRepository.GetGoods()
                .Where(g => g.Name.Trim().ToUpper() == goodCreate.Name.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (good != null)
            {
                ModelState.AddModelError("", "This good already exists!");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_goodsRepository.CreateGood(goodCreate))
            {
                ModelState.AddModelError("", "Something went wrong while saving.");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully created!");
        }

        [HttpPut("{goodId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public IActionResult UpdateGood(int goodId, [FromBody] Goods updatedGood)
        {
            if (updatedGood == null)
                return BadRequest(ModelState);

            if (goodId != updatedGood.Id)
                return BadRequest(ModelState);

            if (!_goodsRepository.GoodExists(goodId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_goodsRepository.UpdateGood(updatedGood))
            {
                ModelState.AddModelError("", "Something went wrong with the update.");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{goodId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public IActionResult DeleteGood(int goodId)
        {
            if (!_goodsRepository.GoodExists(goodId))
                return NotFound();

            var goodToDelete = _goodsRepository.GetGoodsById(goodId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_goodsRepository.DeleteGood(goodToDelete))
            {
                ModelState.AddModelError("", "Something went wrong");
            }

            return NoContent();

        }
    }
}
