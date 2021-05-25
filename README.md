# EmissoraAudienciaWebApiTest

Aplicação em .NET core C# e base de dados SQLExpress, contendo os seguintes critérios:

1.	Cadastro de Emissoras – CRUD de emissoras:

Campos:
•	Id
•	Nome

Regras:
a)	Não permite incluir uma emissora já existente no banco;
b)	Não permite a inclusão de caracteres especiais no nome da emissora

2.	Cadastro de Audiência - CRUD de audiências:

Campos: 
•	Id
•	Pontos_audiencia
•	Data_hora_audiencia
•	Emissora_audiencia

Regras: 
a)	Não permite incluir uma audiência para a mesma emissora na mesma data_hora

3.	Relatório de Audiência por emissora
a)	Informar a data para exibição de uma audiência;
b)	Selecionar qual visão deseja (somatório de audiência por dia ou média de audiência por dia)
