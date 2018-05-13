# Calculadora de médias UNINTER

Calculadora de médias do curso de Análise e Desenvolvimento de Sistemas
Início do projeto: 08/05/2018

## Objetivo
 Este projeto tem o intuito de criar uma ferramenta capaz de funcionar 
em qualquer computador, que dê suporte às funcionalidades 
do Microsoft .NetFramework 4.5, de forma offline (sem acesso a internet), Além de servir como exercício prático para os alunos que quiserem contribuir com o projeto.

## Dependências
 - .[NetFramework 4.5](https://www.microsoft.com/pt-br/download/details.aspx?id=42642) (para os sistemas Windows);
 - [Mono](https://www.mono-project.com/download/stable/) (para Linux)
 
 ## Download:
 Faça o download do arquivo zip da ultima versão na aba [Releases](https://github.com/Gustavo-Kuze/Calculadora-de-medias-UNINTER/releases)
 
 # Instalação
 ## Linux
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
Selecione a opção "Others" digitando o número correspondente e digite:
```
mono %f
```
Pronto!
 
 ## Windows
 Com o .NetFramework 4.5 instalado é só dar 2 cliques no executável e pronto, não é necessário instalação.
 
 ## Aviso
- O programa foi testado nos sistemas Windows 7 32 bit, Windows 8.1 64 bit, Windows 10 64 bit e Ubuntu 18.04 LTS. Caso não funcione no seu sistema, por favor me avise!

- Como não tive nenhum tipo de contato com professores até o momento para desenvolver este projeto, todos os cálculos estão sendo baseados no manual do aluno presente no [site da Uninter](https://www.uninter.com/manual-do-aluno/); Logo, alguns cálculos não estão presentes, como o cálculo de média do exame do curso semipresencial de Gestão, por não estarem presentes no manual.

- O projeto está sendo escrito em CSharp no momento, por se tratar da linguagem que melhor domino, contudo, pretendo criar uma versão que seja uma extensão de navegador (provalvelmente escrita em JS), para facilitar a portabilidade do mesmo para outras plataformas não capazes de emularem o DotNet, que ainda assim sejam capazes de acessar um navegador.

- Aos colegas interessados em ajudar, entrem em contato no meu email gustavoksilva@gmail.com que os adicionarei como colaboradores aqui.

