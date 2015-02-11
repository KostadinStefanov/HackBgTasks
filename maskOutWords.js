function maskOutWords(words, text){

	words.forEach(function(userword) {
        var r = new RegExp(userword, "ig");
        text = text.replace(r, Array(userword.length+1).join("*"));
    });

    console.log(text.replace(/(\n)/g, '\\n'));

}

maskOutWords(["yesterday", "Dog", "food", "walk"], "Yesterday, I took my dog for a walk.\n It was crazy! My dog wanted only food.")
maskOutWords(["PHP"], "We love coding in PHP!\nThis makes us really productive")
