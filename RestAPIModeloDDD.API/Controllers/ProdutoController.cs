using Microsoft.AspNetCore.Mvc;
using RestAPIModeloDDD.application.Dtos;
using RestAPIModeloDDD.application;
using RestAPIModeloDDD.application.Interfaces;

namespace RestAPIModeloDDD.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoApplicationService produtoApplicationService;

        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            this.produtoApplicationService = produtoApplicationService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(produtoApplicationService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(produtoApplicationService.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                produtoApplicationService.Add(produtoDTO);
                return Ok("produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                produtoApplicationService.Update(produtoDTO);
                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                produtoApplicationService.Remove(produtoDTO);
                return Ok("Produto Removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
