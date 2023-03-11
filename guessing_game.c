#include <stdio.h>
#include <stdlib.h>
#include <cs50.h>
#include <time.h>
#include <unistd.h>



int get_random_number() {
    int random_number = rand() % 100 + 1;
    return random_number;
}


struct Game {
    int random_number, guesses, _guess;
    string name;
};


int main() {
    srand(time(NULL));
    struct Game game;
    game.guesses = 20;
    game._guess = 1;
    printf("Welcome to my guessing game! You will have 20 tries to guess a number between 1 and 100! But first, what is your name? ");
    game.name = get_string("");
    printf("Well, %s, I am thinking of a number between 1 and 100.\n", game.name);
    game.random_number = get_random_number();
    while (game.guesses > 0) {
        printf("Take a guess: ");
        int guess = get_int("");
        if (guess < game.random_number) {
            printf("Your guess is too low!\n");
            game.guesses--;
            game._guess++;
        }
        else if (guess > 100) {
            printf("That for sure isn't my number, but I'll give you another guess because I feel bad.\n");
        }
        else if (guess > game.random_number) {
            printf("Your guess is too high!\n");
            game.guesses--;
            game._guess++;
        }
        else {
            printf("You guessed correctly!\n");
            printf("Guesses: %i\n", game._guess);
            break;
        }
    }
    if (game.guesses == 0) {
        printf("You ran out of guesses!\n");
        sleep(1);
        printf("The number was %d.\n", game.random_number);
        printf("Better luck next time, %s!\n", game.name);
        return 0;
    }

}