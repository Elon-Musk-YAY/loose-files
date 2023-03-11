#include <stdlib.h>
#include <stdio.h>

int main () {
    int age = 30;
    double gpa = 3.4;
    char grade = 'A';

    printf("age: %p\ngpa: %p\ngrade: %p\n", &age, &gpa, &grade);
    return 0;
}