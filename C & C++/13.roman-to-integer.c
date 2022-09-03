/*
 * @lc app=leetcode id=13 lang=c
 *
 * [13] Roman to Integer
 */

// @lc code=start

#include <string.h>

int romanToInt(char* s){
    int total = 0;

    for(int i = 0; i < strlen(s); i++) {
        switch (s[i]) {
            case 'M':
                total += 1000;
                break;

            case 'D':
                total += 500;
                break;

            case 'C':
                if(i == strlen(s) - 1) {
                    total += 100;
                    break;
                } else if(s[i + 1] == 'M' || s[i + 1] == 'D') {
                    total -= 100;
                    break;
                } else {
                    total += 100;
                    break;
                }

            case 'L':
                total += 50;
                break;

            case 'X':
                if(i == strlen(s) - 1) {
                    total += 10;
                    break;
                } else if(s[i + 1] == 'C' || s[i + 1] == 'L') {
                    total -= 10;
                    break;
                } else {
                    total += 10;
                    break;
                }

            case 'V':
                total += 5;
                break;

            case 'I':
                if(i == strlen(s) - 1) {
                    total += 1;
                    break;
                } else if(s[i + 1] == 'X' || s[i + 1] == 'V') {
                    total -= 1;
                    break;
                } else {
                    total += 1;
                    break;
                }
        }
    }

    return total;
}
// @lc code=end

