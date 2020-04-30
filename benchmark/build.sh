set -e
base_dir=$(cd "$(dirname "$0")";pwd)
cd $base_dir/1.5.0

rm build -rf
mkdir build  
pushd build

cmake -DCMAKE_BUILD_TYPE=Release -DCMAKE_INSTALL_PREFIX=/usr/local/ \
      -DBENCHMARK_ENABLE_GTEST_TESTS=OFF ..
make -j4
make install

popd
rm build -rf
