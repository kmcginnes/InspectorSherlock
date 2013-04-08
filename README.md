InspectorSherlock
=================

An analysis engine which takes a current state and infers a list of probable commands that will result in the given expected state.

Why, it's elementary my dear Watson!

This is very much a work in progress

Below are the notes taken durring a late night design meeting.

* Have a case which is the old object and the new object with the mystery of what has changed between them. Basically finding the delta as a list of commands

## Dictionary & Requirements
* Newton's Third Law - Pulls together all dependencies and loops over the possible commands for the aggregate in question and collects the resulting data for execution.
* Case - overall container or aggregate
* Probabilities - the command that is probably the user's intention returns a suspect
* Suspect - the return type of the probability method
* Possibilities - the list of possible commands on the subject
* Subject - the object 
* Suspicions
* Probable Cause
* Hypothesis - collection of probabilities returned from the accusations
* Accusation - possibly related to the method on the handler that would be called from the engine to decide the probability of the involvement of that command
* Inspector
* Line Up
* Case is solved.

* Where case is not solved, throw out the SorryboutchaExcpeption
  - This would result when the current cannot be made to match the expected

* We have to add/eliminate suspects

## Code example

Here's an example of what the code might look like:

    var suspectTypes = new [] {
        typeof(AddCigar),
        typeof(RemoveCigar),
        typeof(PurchaseCigarBox),
    };
    SuspectList.AddCase<CigarBox>().With(suspectTypes);
    var hypothesis = Sherlock.BuildCase(oldCigarBox, newCigarBox).InferSuspects();
