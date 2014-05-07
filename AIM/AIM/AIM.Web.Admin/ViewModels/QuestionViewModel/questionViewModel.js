app.viewModel = (function (logger, questionDataService) {

    var suspendItemSave = false;

    var vm = {
        newItem: ko.observable(""),
        newItems: ko.observableArray([]),
        items: ko.observableArray(),
        createQuestion: createQuestion,
        addOption: addOption,
        addAnswer: addAnswer,
        edit: edit,
        completeEdit: completeEdit, 
        removeItem: removeItem
    };

    initVm();
    
    return vm; // done with setup; return module variable

    //#region private functions
    function initVm() {
    }

    function getAllQuestions() {
        questionDataService.getAllQuestions()
            .then(querySucceeded)
            .fail(queryFailed);
    }

    function querySucceeded(data) {
        vm.items([]);
        data.results.forEach(function (item) {
            extendItem(item);
            vm.items.push(item);
        });
        logger.info("Fetched Questions ");
    }

    function queryFailed(error) {
        logger.error(error.message, "Query failed");
    }

    function addOption() {
        var item = questionDataService.createOption();
        questionDataService.saveChanges().fail(addFailed);
        extendItem(item);
        vm.items.push(item);
        vm.newItem("");

        function addFailed() {
            var index = vm.items.indexOf(item);
            if (index > -1) {
                setTimeout(function () { vm.items.splice(index, 1); }, 2000);
            }
        }
    }

    function addAnswer() {
        var item = questionDataService.createAnswer();
        questionDataService.saveChanges().fail(addFailed);
        extendItem(item);
        vm.items.push(item);
        vm.newItem("");

        function addFailed() {
            var index = vm.items.indexOf(item);
            if (index > -1) {
                setTimeout(function () { vm.items.splice(index, 1); }, 2000);
            }
        }
    }

    function extendItem(item) {
        if (item.isEditing) return; // already extended

        item.isEditing = ko.observable(false);

        // listen for changes with Breeze PropertyChanged event
        item.entityAspect.propertyChanged.subscribe(function () {
            if (suspendItemSave) { return; }
            // give EntityManager time to hear the change
            setTimeout(saveIfModified, 0);

            function saveIfModified() {
                if (item.entityAspect.entityState.isModified()) {
                    questionDataService.saveChanges();
                }
            }
        });
    }

    function edit(item) {
        if (item) { item.isEditing(true); }
    }

    function completeEdit(item) {
        if (item) { item.isEditing(false); }
    }

    function removeItem(item) {
        vm.items.remove(item);
        item.entityAspect.setDeleted();
        questionDataService.saveChanges();
    }

    //#endregion    

})(app.logger, app.questionDataService);

// Bind viewModel to view in index.html
ko.applyBindings(app.questionViewModel);