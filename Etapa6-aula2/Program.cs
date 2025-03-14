using System.Security.Cryptography;
using Biblioteca;




public class Program
{
    static void Main(string[] args)
    {
        try
        {
            string nomeRazaoSocial;
            string documento;
            DateTime dataNascimento;


            //throw new BusinessExcpetion("teste de excpetion por RN");

            List<Pessoa> lstPessoa = new List<Pessoa>();

            string key = string.Empty;

            //Console.WriteLine("**Digita J para juridica e F para fisica***");

            //key = Console.ReadLine();

            //while (key != "0")
            //{
            //    Console.WriteLine("Digite nome ou Razao Social:");
            //    nomeRazaoSocial = Console.ReadLine();

            //    Console.WriteLine("Digite Documento:");

            //    documento = Console.ReadLine();

            //    if (key.ToUpper() == "J")
            //    {
            //        lstPessoa.Add(new PessoaJuridica(documento, nomeRazaoSocial));
            //    }

            //    if (key.ToUpper() == "F")
            //    {
            //        dataNascimento = DateTime.Now;

            //        lstPessoa.Add(new PessoaFisica(documento, nomeRazaoSocial, DateTime.Now));
            //    }

            //    Console.Write("Digite uma opção:");
            //    key = Console.ReadLine();
            //}

            Fabricante fabricante = new Fabricante("Estrela", "Produtos Infantis");

            Produto prod1 = new Produto(fabricante, "NomeProduto", 100, 5);
            prod1.RemoverEstoque();
            prod1.RemoverEstoque(1);
            Console.WriteLine(prod1.ToString());


            Fila<Pessoa> fila = new Fila<Pessoa>();

            fila.ColocarNaFila(new PessoaJuridica("83754632921933", "Empresa de Software"));
            fila.ColocarNaFila(new PessoaFisica("12331233", "Nome PF2", DateTime.Now));
            fila.ColocarNaFila(new PessoaFisica("22222222", "Nome PF3", DateTime.Now));
            fila.ColocarNaFila(new PessoaJuridica("83754632921933", "Empresa de Software"));

            fila.ImprimirFila();

            fila.RetirarDaFila();

            fila.ImprimirFila();



            lstPessoa.Add(new PessoaJuridica("83754632921933", "Empresa de Software"));
            lstPessoa.Add(new PessoaFisica("12331233", "Nome PF2", DateTime.Now));
            lstPessoa.Add(new PessoaJuridica("83754632921933", "Empresa de Software"));
            lstPessoa.Add(new PessoaFisica("22222222", "Nome PF3", DateTime.Now));
            lstPessoa.Add(new PessoaJuridica("83754632921933", "Empresa de Software"));

            foreach (Pessoa p in lstPessoa)
            {
                try
                {
                    if (p is PessoaJuridica)
                    {
                        Console.WriteLine($"Razao Social: {((PessoaJuridica)p).RazaoSocial}");

                        double retornoRenda = ((PessoaJuridica)p).RetornarRendaDesconto(10000);

                        Console.WriteLine($"Lucro liquido: {retornoRenda:F2}");
                    }
                    else
                    {
                        DateTime data = new DateTime(1977, 09, 03);
                        string tempo = ((PessoaFisica)p).CalcularTempoVida(data);
                        Console.WriteLine($"Nome pessoa {((PessoaFisica)p).Cpf}");
                    }

                }
                catch
                {
                    throw new BusinessExcpetion("Erro no cadastro de tipo pessoa");
                }

                Console.WriteLine($"Documento:{p.Documento}");
            }
        }
        catch (BusinessExcpetion be)
        {
            Console.WriteLine(be.Message);
        }
        catch (Exception e)
        {
        }
        finally
        {

        }




        Console.ReadKey();

    }
}

