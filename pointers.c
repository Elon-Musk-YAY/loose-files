#include <stdlib.h>
#include <stdio.h>

int main () {
    int age = 30;
    int *age_ptr = &age;
    double gpa = 3.4;
    double *gpa_ptr = &gpa;
    char grade = 'A';
    char *grade_ptr = &grade;
    printf("age's memory address: %p\n", age_ptr);
    printf("gpa's memory address: %p\n", &gpa);
    printf("gpa's value is: %f\n", *gpa_ptr);
    return 0;
}