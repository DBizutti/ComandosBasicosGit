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

            Console.WriteLine("► VOLTAR AO COMMIT ATUAL - COMANDO CLEAN E CHECKOUT");
            Console.WriteLine("-- Esses comando sao usados caso de algum erro ou voce se perca no projeto, ele volta para o estado do ultimo commit feito, descartando todas as modificacoes");
            Console.WriteLine("- Para voltar ao estado do ultimo commit, digite:\n" +
                "'git clean -df'\n" +
                "Após esse comando digite:\n" +
                "'git checkout -- .'\n");

            Console.WriteLine("► DESFAZER O ULTIMO COMMIT - COMANDO RESET");
            Console.WriteLine("- Para excluir o ultimo commit e manter as alteraçoes, digite:\n" +
                "'git reset --soft HEAD~1'\n" +
                "- Para excluir o ultimo commit e também as alteraçoes, digite:\n" +
                "'git reset --hard HEAD~1'\n");

            Console.WriteLine("► VISUALIZAR ALGUM COMMIT ANTERIOR - COMANDO CHECKOUT");
            Console.WriteLine("-- Para apenas visualizar o projeto nos commits anteriores o projeto atual precisa estar sem alteraçoes, ou seja, nada para commitar\n" +
                "- Para visualizar, digite:\n" +
                "'git checkout CODIGO DO COMMIT'\n" +
                "Para voltar ao projeto atual, digite:\n" +
                "'git checkout NOME DA BRANCH'\n");

            Console.WriteLine("► ASSOCIANDO A UM REPOSITORIO REMOTO - COMANDO ADD E SET-URL");
            Console.WriteLine("- Para associar o repositório local ao repositorio remoto, dando o apelido de 'origin' a ele:\n" +
                "'git remote add origin URL DO REPOSITORIO REMOTO'\n" +
                "- Para associar o repositório local a um outro repositorio remoto, mantendo o mesmo o apelido:\n" +
                "'git remote set-url origin URL DO REPOSITORIO REMOTO'\n'");

            Console.WriteLine("► TRANSFERINDO PARA O REPOSITORIO REMOTO - COMANDO PUSH");
            Console.WriteLine("- Para transferir os arquivos pela primeira vez:\n" +
                "'git push -u <APELIDO> <BRANCH>'\n" +
                "- Para transferir os arquivos modificados:\n" +
                "'git push'\n");

        
        
        
        }
    }
}
