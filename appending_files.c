#include <stdio.h>
#include <stdlib.h>


int main () {

    FILE * fpointer = fopen("test.txt", "a");
    for (int i = 0; i < 500; i++) {
            fprintf(fpointer, "Hello World part 2 deez nutz!\n");
    }
    fclose(fpointer);
    return 0;
}