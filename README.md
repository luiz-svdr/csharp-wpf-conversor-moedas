# C# WPF Currency Converter

Projeto de estudo em C# (.NET/WPF): um conversor de moedas para desktop, com foco em lógica de conversão, organização de código em camadas (Models/Services) e tratamento de valores monetários com precisão decimal.

## Tecnologias

C#, .NET, WPF, XAML.

## Estrutura

```
MyCurrencyConverter/
├── Models/
├── Services/
│   └── ConversaoService.cs
├── Resources/
│   ├── ProjectDictionary.xaml
│   └── Assets/
├── App.xaml
├── MainWindow.xaml
```

## Funcionalidades

Interface com campos de entrada de valor, seleção de moeda de origem e destino, e exibição do valor convertido.

ConversaoService responsável pela lógica de conversão entre moedas, utilizando taxas de câmbio fixas e o tipo decimal para maior precisão em cálculos monetários (em vez de double).

## Próximas etapas

Validação de entrada, tratamento de erros e, como extensão futura, consumo de uma API de câmbio real (introduzindo HttpClient e async/await).

Projeto em desenvolvimento contínuo como estudo de C# e WPF.
