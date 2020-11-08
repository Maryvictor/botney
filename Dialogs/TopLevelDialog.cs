// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using System.IO;

namespace Microsoft.BotBuilderSamples
{
    public class TopLevelDialog : ComponentDialog
    {
        // Define a "done" response for the company selection prompt.
        private const string DoneOption = "done";

        // Define value names for values tracked inside the dialogs.
        private const string UserInfo = "value-userInfo";

        public TopLevelDialog()
            : base(nameof(TopLevelDialog))
        {
            AddDialog(new TextPrompt(nameof(TextPrompt)));
            AddDialog(new NumberPrompt<int>(nameof(NumberPrompt<int>)));

            // AddDialog(new ReviewSelectionDialog());

            AddDialog(new WaterfallDialog(nameof(WaterfallDialog), new WaterfallStep[]
            {
                NomeUsuarioStepAsync,
                Resposta1StepAsync,
                Resposta2StepAsync,
                Resposta3StepAsync,
                Resposta4StepAsync,
                Resposta5StepAsync,
                Resposta6StepAsync,
                Resposta7StepAsync,
                Resposta8StepAsync,
                Resposta9StepAsync,
                Resposta10StepAsync,
                Resposta11StepAsync,
                Resposta12StepAsync,
                Resposta13StepAsync,
                Resposta14StepAsync,
                Resposta15StepAsync,
                Resposta16StepAsync,
                Resposta17StepAsync,
                Resposta18StepAsync,
                Resposta19StepAsync,
                Resposta20StepAsync,
                Resposta21StepAsync,
                Resposta22StepAsync,
                Resposta23StepAsync,
                Resposta24StepAsync,
                Resposta25StepAsync,
                Resposta26StepAsync,
                Resposta27StepAsync,
                Resposta28StepAsync,
                Resposta29StepAsync,
                Resposta30StepAsync,
                Resposta31StepAsync,
                Resposta32StepAsync,
                Resposta33StepAsync,
                Resposta34StepAsync,

                

                AcknowledgementStepAsync,
            }));

            InitialDialogId = nameof(WaterfallDialog);
        }
        private static async Task<DialogTurnResult> NomeUsuarioStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            // Create an object in which to collect the user's information within the dialog.
            stepContext.Values[UserInfo] = new UserProfile();

            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Antes de começarmos, me diga o seu nome.") };
            // Ask the user to enter their name.
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta1StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.nomeUsuario = (string)stepContext.Result;
            //
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Acordo todo dia e agradeço por...") };

            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta2StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta1 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("O que eu gosto na minha casa é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        //
        private static async Task<DialogTurnResult> Resposta3StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta2 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Quando saio de casa, peço por...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta4StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta3 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Quando estou a caminho do trabalho, normalmente estou...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta5StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta4 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("O que eu mais gosto na minha cidade é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta6StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta5 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Meu restaurante favorito da cidade é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta7StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta6 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Quando vou ao parque, normalmente eu...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta8StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta7 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Se eu pudesse estar em qualquer outro lugar, eu estaria...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta9StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta8 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Um dia eu vou...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta10StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta9 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Eu sou inspirado por...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta11StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta10 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("O que me engaja de verdade é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta12StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta11 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Uma pesssoa que me encanta é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta13StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta12 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Se eu fosse jogador de futebol, jogaria como...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta14StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta13 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("O país que eu mais amei visitar foi...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta15StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta14 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Minha banda favorita é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta16StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta15 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Minha música favorita na infância era...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta17StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta16 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Estou evitando, mas um dia aprendo a...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta18StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta17 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("O amanhã pra mim é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta19StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta18 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Se eu tivesse um pedido para o mundo, ele seria...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta20StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta19 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Se eu criasse um aplicativo, ele seria para...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta21StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta20 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Meu esporte favorito é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta22StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta21 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Minha maior lição de vida foi...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta23StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta22 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Meu animal favorito é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta24StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta23 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Se eu fosse um animal, seria...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }

        private static async Task<DialogTurnResult> Resposta25StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta24 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("No karaokê, a primeira música que eu canto é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta26StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta25 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Amigos pra mim significam...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta27StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta26 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Gosto de pensar que sou...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta28StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta27 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Nas minhas próximas férias, eu vou...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta29StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta28 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Minha bebida favorita é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta30StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta29 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Trabalho para mim é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta31StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta30 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Diversão para mim é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta32StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta31 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Amor para mim é...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta33StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta32 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Meu apelido de criança era...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        private static async Task<DialogTurnResult> Resposta34StepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var userProfile = (UserProfile)stepContext.Values[UserInfo];
            userProfile.resposta33 = (string)stepContext.Result;
            var promptOptions = new PromptOptions { Prompt = MessageFactory.Text("Na escola, eu era da turma...") };
            return await stepContext.PromptAsync(nameof(TextPrompt), promptOptions, cancellationToken);
        }
        //
        private async Task<DialogTurnResult> AcknowledgementStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            // Set the user's company selection to what they entered in the review-selection dialog.
            var userProfile = (UserProfile)stepContext.Values[UserInfo];


            using (System.IO.StreamWriter file =
                                      new System.IO.StreamWriter(@"C:\Users\teste\Documents\Carambola\43.complex-dialog\ResultadoArquivo.json", true))

                file.WriteLine("[" + (userProfile.nomeUsuario + ",") +
                (userProfile.resposta1 + ",") +
                (userProfile.resposta2 + "]")

                );


            // Thank them for participating.
            await stepContext.Context.SendActivityAsync(
                MessageFactory.Text($"Obrigada por sua participação, {((UserProfile)stepContext.Values[UserInfo]).nomeUsuario}!"),
                cancellationToken);

            // Exit the dialog, returning the collected user information.
            return await stepContext.EndDialogAsync(stepContext.Values[UserInfo], cancellationToken);
        }

    }
}
