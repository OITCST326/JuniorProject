app.dataservice = (function (breeze, logger) {

    var serviceName = 'breeze/QuestionBreeze'; // route to the same origin Web Api controller

    var manager = new breeze.EntityManager(serviceName);
    manager.enableSaveQueuing(true);

    return {
        getAllQuestions: getAllQuestions,
        createQuestion: createQuestion,
        saveChanges: saveChanges,
        purge: purge,
        reset: reset
    };

    /*** implementation details ***/

    //#region main application operations
    function getAllQuestions() {
        var query = breeze.EntityQuery
            .from("Questions");

        for (item in query) {
            
        }

        return manager.executeQuery(query);
    }

    function createQuestion() {
        return manager.createEntity('Question');
    }

    function createOption() {
        return manager.createEntity('Question.qJsonOptionList');
    }

    function createAnswer() {
        return manager.createEntity('Question.qJsonAnswerList');
    }

    function saveChanges() {
        return manager.saveChanges()
            .then(saveSucceeded)
            .fail(saveFailed);

        function saveSucceeded(saveResult) {
            logger.success("Question Saved");
            logger.log(saveResult);
        }

        function saveFailed(error) {
            var reason = error.message;
            var detail = error.detail;

            if (error.entityErrors) {
                reason = handleSaveValidationError(error);
            } else if (detail && detail.ExceptionType &&
                detail.ExceptionType.indexOf('OptimisticConcurrencyException') !== -1) {
                // Concurrency error 
                reason =
                    "Another user, perhaps the server, " +
                    "may have deleted one or all of the questions." +
                    " You may have to restart the app.";
            } else {
                reason = "Failed to save changes: " + reason +
                         " You may have to restart the app.";
            }

            logger.error(error, reason);

            //// Let them see the error for a second before rejecting changes
            //setTimeout(function () {
            //    manager.rejectChanges();
            //}, 2000);

            throw error; // so caller can see it
        }
    }

    function handleSaveValidationError(error) {
        var message = "Not saved due to validation error";
        try { // fish out the first error
            var firstErr = error.entityErrors[0];
            message += ": " + firstErr.errorMessage;
        } catch (e) { /* eat it for now */ }
        return message;
    }

    //#endregion
})(breeze, app.logger);