﻿
using ListaH1.Infra.EmailService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ListaH1.H1.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteEmailController : ControllerBase
    {
        private readonly EmailConfig _emailConfig;

        public TesteEmailController(IOptions<EmailConfig> options)
        {
            _emailConfig = options.Value;
        }

        [HttpPost]
        [Route("EnviarEmail")]
        public async Task<IActionResult> Post()
        {
            string assunto = "Estoque Esgotado";
            string corpoEmailModelo = "Olá Comprador(a) , o produto {descricaoProduto} está abaixo do estoque mínimo{estoqueMinimo} definido no sistema, logo, você precisa avaliar se é necessário realizar um novo pedido de compra.";
            string nome = "João";
            string emailDestino = "joaokz10@outlook.com";

            string corpoEmail = corpoEmailModelo.Replace("{nomeCliente}", nome);

            if (!string.IsNullOrEmpty(emailDestino))
                Email.Enviar(assunto, corpoEmail, emailDestino, _emailConfig);

            return Ok("Emails Enviado Com Sucesso!");

        }
    }
}
