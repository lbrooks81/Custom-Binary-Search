namespace CustomBinarySearch
{
    public static class Source
    {
        public static int BinarySearch(int[] arr, int match)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == match)
                {
                    return mid;
                }
                else if (arr[mid] > match)
                {
                    right = mid - 1;
                }
                else if (arr[mid] < match)
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
