using System;
using Xunit;
using Jokenpo;
using Jokenpo.Entities;
using Xunit.Abstractions;
//using Partida; // tentei

namespace JokenpoTeste
{
    public class Testes01
    {
        private readonly ITestOutputHelper _output; 
        public Testes01(ITestOutputHelper output){ 
            _output = output;
        }

        [Fact (DisplayName = "Verificar se Pedra Vence para Papel")]
        public void VerificarSePedraVence()
        {
            //Arrange
            var partida = new Partida();
            var opcao = 1;
            var robo =3;
            var expected = 1;
                      
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            _output.WriteLine(message:$"VerificarSePedraVence: Usuário escolheu : {opcao} e Robô escolheu {robo}");
            Assert.Equal(expected, result);
           
        }
        [Fact (DisplayName = "Verificar se Papel vence Pedra")]
        public void VerificarSePapelVence()
        {
            //Arrange
            var partida = new Partida();
            var opcao = 2;
            var robo =1;
            var expected = 1;
                      
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            _output.WriteLine(message:$"VerificarSePapelVence: Usuário escolheu : {opcao} e Robô escolheu {robo}");
            Assert.Equal(expected, result);
           
        }
        [Fact (DisplayName = "Verificar se Tesoura vence Papel")]
        public void VerificarSeTesouraVence()
        {
            //Arrange
            var partida = new Partida();
            var opcao = 3;
            var robo =2;
            var expected = 1;
                      
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            _output.WriteLine(message:$"VerificarSeTesouraVence: Usuário escolheu : {opcao} e Robô escolheu {robo}");
            Assert.Equal(expected, result);
           
        }
       
        [Fact (DisplayName = "Verificar se Tesoura perde para Pedra")]
        public void VerificarSeTesouraPerde() 
        {
            //Arrange
            var partida = new Partida();
            var opcao = 3;
            var robo = 1;
            var expected = -1;
                      
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            _output.WriteLine(message:$"VerificarSeTesouraPerde: Usuário escolheu : {opcao} e Robô escolheu {robo}");
            Assert.Equal(expected, result);
           
        }
        
        [Fact(DisplayName = "Verificar se Papel perde para Tesoura")]
        public void VerificarSePapelPerde()
        {
            //Arrange
            var partida = new Partida();
            var opcao = 2;
            var robo =3;
            var expected = -1;
                      
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            _output.WriteLine(message:$"VerificarSePapelPerde: Usuário escolheu : {opcao} e Robô escolheu {robo}");
            Assert.Equal(expected, result);
           
        }
        
        [Fact(DisplayName = "Verificar se Pedra perde para Papel")]
         public void VerificarSePedraPerde()
        {
            //Arrange
            var partida = new Partida();
            var opcao = 1;
            var robo =2;
            var expected = -1;
                      
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            _output.WriteLine(message:$"VerificarSePedraPerde: Usuário escolheu : {opcao} e Robô escolheu {robo}");
            Assert.Equal(expected, result);
           
        }
        [Theory(DisplayName = "Verificar Empates")]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(3, 3, 0)]
        public void VerificarEmpates(int opcao, int robo, int expected)
        {
            //Arrange
            var partida = new Partida();
                    
            //Act
            var result = partida.Resultado(opcao, robo);
        
            //Assert
            Assert.Equal(expected, result);


        }
        [Theory(DisplayName = "Escolha do Usuário")]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("0")]
        public void EscolhaDoUsuario(string opcao)
        {
            //Arrange
            var partida = new Partida();

            //Act
            var result = partida.Pessoa(opcao);
            var expected = int.Parse(opcao) > 3 || int.Parse(opcao) == 0 ? 0 : int.Parse(opcao);
                      
            //Assert
            Assert.Equal(expected, result);


        }

    }
}
