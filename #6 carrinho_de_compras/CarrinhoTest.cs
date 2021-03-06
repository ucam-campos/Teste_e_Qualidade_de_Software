using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Application
{
	[TestFixture ()]
	public class CarrinhoTest
	{
		private Carrinho carrinho;
		private Produto produto	;
		private List<Produto> produtos_esperados;
		[SetUp]
		protected void SetUp() 
		{
			carrinho = new Carrinho();
			produto = new Produto ("Nome do Produto", 50f);
			produtos_esperados = new List<Produto> ();
			produtos_esperados.Add (produto);
		}

		[Test]
		public void AdicaoDeProdutos ()
		{
			carrinho.Adicionar (produto);
			Assert.AreEqual (produtos_esperados, carrinho.Produtos());
		}
		[Test]
		public void AumentoDaQuantidadeDoProduto ()
		{
			carrinho.Adicionar (produto);
			Assert.AreEqual (1, carrinho.Quantidade(produto));
		}

		[Test]
		public void CalculoDePrecoTotal ()
		{
			carrinho.Adicionar (produto);
			Assert.AreEqual (50f, carrinho.Total());
		}
	}
}

