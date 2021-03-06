/**
 * @brief State machine stub implementation file
 * Generated to aid in the rapid creation of state machine implementations
 *
 * @file {{name}}-stub.cs
 * @date {{date}}
 */
 
using System;

namespace StateMachines
{
	public class {{camelCase @root.name}}Impl : {{camelCase @root.name}}
	{

		/***		State and Transition Stubs				***/

		//State machine transition function stubs
		{{#each this.transitions}}
		protected override void {{camelCase name}}TransitionHandler(Data data) {
			Console.WriteLine("FSM: {{@root.name}} State: {{name}} transition function called");
		}
		{{/each}}

		//State machine state function stubs
		{{#each this.states}}

		{{#if this.events.onEntry}}
		//State {{name}} entry function
		protected override void {{camelCase name}}EntryHandler(Data data){
			Console.WriteLine("FSM: {{@root.name}} State: {{name}} entry function called");
		}
		{{/if}}
		{{#if this.events.onTick}}
		//State {{name}} tick function
		protected override void {{camelCase name}}StateHandler(Data data){
			Console.WriteLine("FSM: {{@root.name}} State: {{name}} tick function called");
		}
		{{/if}}
		{{#if this.events.onExit}}
		//State {{name}} exit function
		protected override void {{camelCase name}}ExitHandler(Data data){
			Console.WriteLine("FSM: {{@root.name}} State: {{name}} exit function called");
		}
		{{/if}}
		{{/each}}	{{! State loop }}
	}
}

