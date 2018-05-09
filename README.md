# Calculadora de médias UNINTER

Calculadora de médias do curso de Análise e Desenvolvimento de Sistemas
Início do projeto: 08/05/2018

## Objetivo
 Este projeto tem o intuito de criar uma ferramenta capaz de funcionar 
em qualquer computador, que dê suporte às funcionalidades 
do Microsoft .NetFramework 4.5, de forma offline (sem acesso a internet).

## Dependências
 - .[NetFramework 4.5](https://www.microsoft.com/pt-br/download/details.aspx?id=42642) (para os sistemas Windows);
 - [Mono](https://www.mono-project.com/download/stable/) (para Linux e Mac)
 
 ## Como instalar no Linux adequadamente
 1- Adicione os PPAs do Mono runtime no seu sistema:
 ```
 sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
echo "deb https://download.mono-project.com/repo/ubuntu stable-bionic main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
sudo apt update
```

2- Instale o Mono:
```
sudo apt-get install mono-complete
```
3- Adicione o Mono como padrão para abrir a aplicação:
```
mimeopen -d ~/Downloads/CalculadoraDeMedia-UNINTER.exe
```
Selecione a opção "Others" digitando o número correspondente
```
mono %f
```
Pronto!
 
 ## Aviso
- Por hora a calculadora faz cálculos apenas para as médias baseadas na área politécnica, porém pretendo ampliar a capacidade para as outras áreas futuramente;
- O projeto está sendo escrito em CSharp no momento, por se tratar da linguagem que melhor domino, contudo, pretendo migrá-lo para um projeto web no futuro, para facilitar a portabilidade do mesmo para outras plataformas não capazes de emularem o DotNet, que ainda assim sejam capazes de acessar um navegador.
- Aos colegas interessados em ajudar, entrem em contato no meu email gustavoksilva@gmail.com que os adicionarei como colaboradores aqui.
