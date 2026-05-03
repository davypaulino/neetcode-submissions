public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int smaller = 1;
        int bigger = smaller;
        foreach (int p in piles) {
            if (p > bigger) {
                bigger = p;
            }
        }

        int k = bigger;
        while (smaller <= bigger) {
            int mid = smaller + (bigger - smaller) / 2;

            bool ate = eatAllBananas(piles, mid, h);
            if (ate == true) {
                k = mid;
                bigger = mid - 1;
            } else if (ate == false) {
                smaller = mid + 1;
            }
        }
        return k;
    }

    private bool eatAllBananas(int[] piles, int k, int h) {
        int i = 0;
        for (; i < piles.Length && h > 0; i++) {
            h -= (int)Math.Ceiling((double)piles[i] / k);
        }
        if (i >= piles.Length && h >= 0)
            return true;
        return false;
    }
}
