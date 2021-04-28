/**
 * @param {number} a
 * @param {number} b
 * @return {number}
 */
var getSum = function(a, b) {
    // iterate till there is no carry 
    while (b != 0) { 
        // carry now contains common set bits of a and b 
        let carry = a & b;
        // sum of bits of a and b where at least one of the bits is not set 
        a = a ^ b; 
        // carry is shifted by one so that adding it to a gives the required sum 
        b = carry << 1; 
    }
    return a; 
};
