using System;

namespace mod8___PrincipaisComandosGit {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("PREPARANDO A PASTA:");
            Console.WriteLine("► CRIAR ARQUIVO .gitignore:");
            Console.WriteLine("-- O .gitignore serve para mostrar ao git os arquivos que não são necesários fazer o versionamento");
            Console.WriteLine("- Crie um arquivo x.txt\n" +
                "- Abra um cmd na pasta, para isso segure a tecla Shift e clique com botão esquerdo do mouse e selecione a opção 'Abrir cmd aqui'\n" +
                "- No cmd digite: 'ren NOMEDOARQUIVO.txt .gitignore'\n" +
                "- Tecle Enter e feche o terminal\n" +
                "OBS.: Em alguns sistemas é possível criar diretamente o arquivo, basta apenas selecionar tudo, incluindo a extensao, e digitar '.gitignore'\n" +
                "- Abra o arquivo com o bloco de notas\n" +
                "- Pesquise por 'gitignore visual studio 2019' ou o editor com a versáo que esteja usando\n" +
                "- Entre no link do github\n" +
                "- Copie tudo, cole no bloco de notas e salve\n");

            Console.WriteLine("► INICIAR O GIT - COMANDO INIT");
            Console.WriteLine("-- O comando 'init' serve para criar um repositório local para controlar as versões");
            Console.WriteLine("- Clique com o botão esquerdo do mouse\n" +
                "- Selecione a opção 'iniciar Git Bash aqui'\n" +
                "- Digite 'git init'\n");


            Console.WriteLine("► CONFIGURAR O GIT - COMANDO CONFIG");
            Console.WriteLine("-- Serve para indicar ao Git quem fez a alteração no programa");
            Console.WriteLine("- Informe seu nome com o comando 'git config --global user.name ''SEU NOME'''\n" +
                " - Informe seu nome com o comando 'git config --global user.email ''SEU EMAIL'''\n" +
                "OBS.: É importante que coloque o email cadastrado no github para vincular à conta posteriormente\n");


            Console.WriteLine("► SALVAR VERSÕES DO PROJETO - COMANDOS ADD - COMMIT - STATUS - LOG");
            Console.WriteLine("- Verifique como está o repositório, para isso digite o comando:\n" +
                "'git status'\n" +
                "Em VERMELHO são os arquivos não rastreados (untracked)\n" +
                "Em VERDE são os arquivos prontos para serem 'commitados' (stage)\n" +
                "- Os arquivos novos ou modificados vao estar em 'untracked', para mover para a área 'stage' digite o comando:\n" +
                "'git add .'\n" +
                "- Após mover os arquivos faca o commit, para isso digite o comando:\n" +
                "'git commit -m ''DESCREVA O QUE FOI FEITO ATÉ O MOMENTO'''\n" +
                "Para verificar todos os commit's existe o comando LOG, que mostra todos os dados do commit, como o nome e email do autor do commit, data e hora, para isso digite:\n" +
                "'git log'\n" +
                "Existe uma forma mais resumida de mostrar os commit's com o comando:\n" +
                "'git log --oneline'\n");

                
            Console.WriteLine("");
        }
    }
}
